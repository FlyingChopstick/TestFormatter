namespace LocalizationLibrary
{
    /// <summary>
    /// Pack of localization strings
    /// </summary>
    public struct LocalizationStrings
    {
        public string L_topic;
        public string L_subtopic;
        public string L_fileExistsY;
        public string L_fileExistsN;
        public string L_statistics;
        public string B_openFile;
        public string B_generate;
        public string GB_question;
    }

    /// <summary>
    /// Output formatting
    /// </summary>
    public struct Formatting
    {
        public const string ThemeFormat = "I: {0}; mt=0,1";
        public const string QuestionFormat = "S: {0}:";
        public const string CAnsFormat = "+: {0}";
        public const string WAnsFormat = "-: {0}";
    }

    /// <summary>
    /// Contains all localization strings
    /// </summary>
    public class StringHolder
    {
        #region Constructors
        /// <summary>
        /// Loads default localization (English)
        /// </summary>
        public StringHolder()
        {

        }

        /// <summary>
        /// Loads custom localization using an array of strings
        /// </summary>
        /// <param name="localizationStrings">Custom localization strings</param>
        public StringHolder(LocalizationStrings localizationStrings)
        {
            L_filename = localizationStrings.L_topic;
            L_qTopic = localizationStrings.L_subtopic;
            L_fileExistsY = localizationStrings.L_fileExistsY;
            L_fileExistsN = localizationStrings.L_fileExistsN;
            L_statistics = localizationStrings.L_statistics;

            B_openFile = localizationStrings.B_openFile;
            B_generate = localizationStrings.B_generate;

            GB_question = localizationStrings.GB_question;
        }
        /// <summary>
        /// Loads localization using an array
        /// </summary>
        /// <param name="localizationStrings"></param>
        public StringHolder(string[] localizationStrings)
        {
            L_filename = localizationStrings[0];
            L_qTopic = localizationStrings[1];
            L_fileExistsY = localizationStrings[2];
            L_fileExistsN = localizationStrings[3];
            L_statistics = localizationStrings[4];

            B_openFile = localizationStrings[5];
            B_generate = localizationStrings[6];

            GB_question = localizationStrings[7];
        }
        #endregion

        #region Labels
        /// <summary>
        /// Filename label
        /// </summary>
        public string L_filename { get; private set; } = "File name";
        /// <summary>
        /// Topic label
        /// </summary>
        public string L_qTopic { get; private set; } = "Topic";
        /// <summary>
        /// File exists label
        /// </summary>
        public string L_fileExistsY { get; private set; } = "File exists: Yes";
        /// <summary>
        /// File does not exist label
        /// </summary>
        public string L_fileExistsN { get; private set; } = "File exists: No";
        /// <summary>
        /// Question stats label
        /// </summary>
        public string L_statistics { get; private set; } = "Since last launch:  #1: {0}   #2: {1}   #3: {2}   #4: {3}";
        #endregion

        #region Buttons
        /// <summary>
        /// Open file button
        /// </summary>
        public string B_openFile { get; private set; } = "Open file";
        /// <summary>
        /// Generate button
        /// </summary>
        public string B_generate { get; private set; } = "Generate";
        #endregion

        #region GroupBoxes
        /// <summary>
        /// Question number group box
        /// </summary>
        public string GB_question { get; private set; } = "Question #{0}";
        #endregion
    }
}
