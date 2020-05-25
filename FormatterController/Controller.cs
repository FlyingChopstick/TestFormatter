using LocalizationLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FormatterController
{
    public enum Language
    {
        English = 0,
        Russian = 1
    }
    public enum QNum
    {
        First = 0,
        Second = 1,
        Third = 2,
        Fourth = 3
    }

    public struct Question
    {
        public string Filename;
        public string Theme;
        public string QuestionText;
        public string ans1, ans2, ans3, ans4;
        public QNum Correct;
    }

    public static class Controller
    {
        #region Paths
        /// <summary>
        /// Topic output folder
        /// </summary>
        private const string outputFolder = @".\Topics\";//@".\Topics\Output\";
        /// <summary>
        /// Topic output prefix
        /// </summary>
        private const string outputPrefix = "topic_";

        private const string locaFolder = @".\Localization\";
        private const string locaExtension = ".loca";

        /// <summary>
        /// Path to active file
        /// </summary>
        public static string ActiveFile { get; private set; } = "FILE NOT SET";
        #endregion

        #region Stats
        /// <summary>
        /// Tracks question count across different topics
        /// </summary>
        public static Dictionary<string, int> QuestionTracking { get; private set; } = new Dictionary<string, int>();
        public static Dictionary<string, int[]> TopicStats { get; private set; } = new Dictionary<string, int[]>();
        #endregion

        #region Language
        /// <summary>
        /// Dictionary of languages and their StringHolders
        /// </summary>
        private static Dictionary<string, StringHolder> localizations = new Dictionary<string, StringHolder>();
        /// <summary>
        /// Current language
        /// </summary>
        public static string CLang { get; private set; } = "English";
        /// <summary>
        /// Current localization StringHolder
        /// </summary>
        public static StringHolder CLoca { get; private set; } = new StringHolder();

        /// <summary>
        /// Loads all localization files from the folder
        /// </summary>
        public static void LoadLocalizations()
        {
            string[] locas = Directory.GetFiles(locaFolder).Where(file => file.Contains(".loca")).ToArray();
            foreach (string file in locas)
            {
                string lang = file.Remove(0, locaFolder.Length);
                lang = lang.Remove(lang.IndexOf("."), locaExtension.Length);

                localizations[lang] = new StringHolder(File.ReadAllLines(file));
            }

        }
        /// <summary>
        /// Sets the active language and localization StringHolder
        /// </summary>
        /// <param name="lang">Language</param>
        public static void SetLocalization(string lang)
        {
            if (localizations.ContainsKey(lang))
            {
                CLang = lang;
                CLoca = localizations[lang];
            }
            else
            {
                throw new ArgumentException("Language not recognized");
            }
        }
        #endregion


        /// <summary>
        /// Creates an output directory, loads localizations
        /// </summary>
        public static void Setup()
        {
            Directory.CreateDirectory(outputFolder);
            localizations["English"] = new StringHolder();
            LoadLocalizations();
        }

        /// <summary>
        /// Formats the question using the format in StringHolder
        /// </summary>
        /// <param name="q"></param>
        public static void Write(Question q)
        {
            string topic = q.Filename;
            string theme = string.Format(Formatting.ThemeFormat, q.Theme);
            string question = string.Format(Formatting.QuestionFormat, q.QuestionText);
            string ans1, ans2, ans3, ans4;

            if (!TopicStats.ContainsKey(topic))
            {
                TopicStats[topic] = new int[] { 0, 0, 0, 0, 0 };
            }

            switch (q.Correct)
            {
                case QNum.First:
                    {
                        //ans1 correct
                        TopicStats[topic][1]++;

                        ans1 = string.Format(Formatting.CAnsFormat, q.ans1);
                        ans2 = string.Format(Formatting.WAnsFormat, q.ans2);
                        ans3 = string.Format(Formatting.WAnsFormat, q.ans3);
                        ans4 = string.Format(Formatting.WAnsFormat, q.ans4);
                        break;
                    }
                case QNum.Second:
                    {
                        //ans2 correct
                        TopicStats[topic][2]++;

                        ans1 = string.Format(Formatting.WAnsFormat, q.ans1);
                        ans2 = string.Format(Formatting.CAnsFormat, q.ans2);
                        ans3 = string.Format(Formatting.WAnsFormat, q.ans3);
                        ans4 = string.Format(Formatting.WAnsFormat, q.ans4);
                        break;
                    }
                case QNum.Third:
                    {
                        //ans3 correct
                        TopicStats[topic][3]++;

                        ans1 = string.Format(Formatting.WAnsFormat, q.ans1);
                        ans2 = string.Format(Formatting.WAnsFormat, q.ans2);
                        ans3 = string.Format(Formatting.CAnsFormat, q.ans3);
                        ans4 = string.Format(Formatting.WAnsFormat, q.ans4);
                        break;
                    }
                case QNum.Fourth:
                    {
                        //ans4 correct
                        TopicStats[topic][4]++;

                        ans1 = string.Format(Formatting.WAnsFormat, q.ans1);
                        ans2 = string.Format(Formatting.WAnsFormat, q.ans2);
                        ans3 = string.Format(Formatting.WAnsFormat, q.ans3);
                        ans4 = string.Format(Formatting.CAnsFormat, q.ans4);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Could not determine the correct answer");
                    }
            }

            string[] newQuestion = { theme, question, ans1, ans2, ans3, ans4 };
            //write
            File.AppendAllLines(ActiveFile, newQuestion);

            TopicStats[topic][0]++;

        }



        public static void SetActiveFile(string topic)
        {
            ActiveFile = $"{outputFolder}{outputPrefix}{topic}.txt";
        }
        public static bool ScanFile(string topic)
        {
            if (File.Exists(ActiveFile))
            {
                //count question in file, assuming each is 7 lines long
                int len = File.ReadAllLines(ActiveFile).Length;
                int qCount = len / 7 + 1;
                if (qCount == 0)
                {
                    QuestionTracking[topic] = 1;
                }
                else
                {
                    QuestionTracking[topic] = qCount;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        public static void OpenActiveFile()
        {
            System.Diagnostics.Process.Start(ActiveFile);
        }

        public static string FormatStats(string topic)
        {
            if (TopicStats.ContainsKey(topic))
            {
                return string.Format(
                        CLoca.L_statistics,
                        TopicStats[topic][1],
                        TopicStats[topic][2],
                        TopicStats[topic][3],
                        TopicStats[topic][4]
                        );
            }
            else
            {
                return string.Format(
                        CLoca.L_statistics,
                        0,
                        0,
                        0,
                        0
                        );
            }
        }
        public static string GetQuestionNumber(string topic)
        {
            if (QuestionTracking.ContainsKey(topic))
            {
                return string.Format(CLoca.GB_question, QuestionTracking[topic] + 1);
            }
            else
            {
                return string.Format(CLoca.GB_question, 1);
            }
        }
    }
}
