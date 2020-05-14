using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public class StringHolder
    {
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
            L_topic = localizationStrings.L_topic;
            L_subtopic = localizationStrings.L_subtopic;
            L_fileExistsY = localizationStrings.L_fileExistsY;
            L_fileExistsN = localizationStrings.L_fileExistsN;
            L_statistics = localizationStrings.L_statistics;

            B_openFile = localizationStrings.B_openFile;
            B_generate = localizationStrings.B_generate;

            GB_question = localizationStrings.GB_question;
        }

        #region Labels
        public string L_topic { get; private set; } = "Topic";
        public string L_subtopic { get; private set; } = "Subtopic";
        public string L_fileExistsY { get; private set; } = "File exists: Yes";
        public string L_fileExistsN { get; private set; } = "File exists: No";
        public string L_statistics { get; private set; } = "Since last launch:  #1: {0}   #2: {1}   #3: {2}   #4: {3}";
        #endregion

        #region Buttons
        public string B_openFile { get; private set; } = "Open file";
        public string B_generate { get; private set; } = "Generate";
        #endregion

        #region GroupBoxes
        public string GB_question { get; private set; } = "Question #{0}";
        #endregion
    }
}
