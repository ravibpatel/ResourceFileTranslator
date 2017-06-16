using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Resource_File_Translator
{
    public partial class FormMain : Form
    {
        private readonly Dictionary<string, string> _languages;

        public FormMain()
        {
            InitializeComponent();
            _languages = new Dictionary<string, string>
                {
                    {"Detect Language", "auto"},
                    {"Afrikaans", "af"},
                    {"Albanian", "sq"},
                    {"Arabic", "ar"},
                    {"Armenian", "hy"},
                    {"Azerbaijani", "az"},
                    {"Basque", "eu"},
                    {"Belarusian", "be"},
                    {"Bengali", "bn"},
                    {"Bulgarian", "bg"},
                    {"Catalan", "ca"},
                    {"Chinese (Simplified)", "zh-CN"},
                    {"Chinese (Traditional)", "zh-TW"},
                    {"Croatian", "hr"},
                    {"Czech", "cs"},
                    {"Danish", "da"},
                    {"Dutch", "nl"},
                    {"English", "en"},
                    {"Esperanto", "eo"},
                    {"Estonian", "et"},
                    {"Filipino", "tl"},
                    {"Finnish", "fi"},
                    {"French", "fr"},
                    {"Galician", "gl"},
                    {"Georgian", "ka"},
                    {"German", "de"},
                    {"Greek", "el"},
                    {"Gujarati", "gu"},
                    {"Haitian Creole", "ht"},
                    {"Hebrew", "iw"},
                    {"Hindi", "hi"},
                    {"Hungarian", "hu"},
                    {"Icelandic", "is"},
                    {"Indonesian", "id"},
                    {"Irish", "ga"},
                    {"Italian", "it"},
                    {"Japanese", "ja"},
                    {"Kannada", "kn"},
                    {"Khmer", "km"},
                    {"Korean", "ko"},
                    {"Lao", "lo"},
                    {"Latin", "la"},
                    {"Latvian", "lv"},
                    {"Lithuanian", "lt"},
                    {"Macedonian", "mk"},
                    {"Malay", "ms"},
                    {"Maltese", "mt"},
                    {"Norwegian", "no"},
                    {"Persian", "fa"},
                    {"Polish", "pl"},
                    {"Portuguese", "pt"},
                    {"Romanian", "ro"},
                    {"Russian", "ru"},
                    {"Serbian", "sr"},
                    {"Slovak", "sk"},
                    {"Slovenian", "sl"},
                    {"Spanish", "es"},
                    {"Swahili", "sw"},
                    {"Swedish", "sv"},
                    {"Tamil", "ta"},
                    {"Telugu", "te"},
                    {"Thai", "th"},
                    {"Turkish", "tr"},
                    {"Ukrainian", "uk"},
                    {"Urdu", "ur"},
                    {"Vietnamese", "vi"},
                    {"Welsh", "cy"},
                    {"Yiddish", "yi"}
                };
            foreach (var language in _languages)
            {
                comboBoxSourceLanguage.Items.Add(language.Key);
                if (!language.Value.Equals("auto"))
                {
                    comboBoxTargetLanguage.Items.Add(language.Key);
                    checkedListBoxLanguages.Items.Add(language.Key);
                }
            }
            comboBoxSourceLanguage.SelectedIndex = 0;
            comboBoxTargetLanguage.SelectedIndex = 16;
        }

        //private string Translate(string sourceLanguage, string targetLanguage, string sourceText)
        //{
        //    var requestURL = string.Format(@"http://translate.google.com/translate_a/t?client=b&ie=UTF-8&oe=UTF-8&sl={0}&tl={1}&q={2}", sourceLanguage, targetLanguage, Uri.EscapeUriString(sourceText));
        //    var gTranslateWebRequest = WebRequest.Create(requestURL);
        //    var gTranslateWebResponse = gTranslateWebRequest.GetResponse();
        //    var targetText = "";
        //    using (var gTranslateResponseStream = new StreamReader(gTranslateWebResponse.GetResponseStream(), Encoding.UTF8, true))
        //    {
        //        var responseText = gTranslateResponseStream.ReadToEnd();
        //        var jObject = JObject.Parse(responseText);

        //        var jArraySentences = (JArray)jObject["sentences"];
        //        targetText = jArraySentences.Aggregate(targetText, (current, jArraySentence) => current + jArraySentence["trans"]);
        //    }
        //    return EscapeTranslatedText(targetText);
        //}

        private static string Translate(string from, string to, string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            string page;
            try
            {
                WebClient wc = new WebClient();
                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                wc.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                wc.Encoding = Encoding.UTF8;

                string url =
                    $@"http://translate.google.com.tr/m?hl=en&sl={from}&tl={to}&ie=UTF-8&prev=_m&q={
                        Uri.EscapeUriString(text)
                    }";

                page = wc.DownloadString(url);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }

            page = page.Remove(0, page.IndexOf("<div dir=\"ltr\" class=\"t0\">", StringComparison.Ordinal)).Replace("<div dir=\"ltr\" class=\"t0\">", "");
            int last = page.IndexOf("</div>", StringComparison.Ordinal);
            page = page.Remove(last, page.Length - last);

            return page;
        }

        //private static string EscapeTranslatedText(string text)
        //{
        //    return
        //        text.Replace(" .", ".")
        //            .Replace(" ?", "?")
        //            .Replace(" !", "!")
        //            .Replace("{ ", "{")
        //            .Replace(" }", "}")
        //            .Replace(" ;", ";")
        //            .Replace("[ ", "[")
        //            .Replace(" ]", "]")
        //            .Replace("( ", "(")
        //            .Replace(" )", ")");
        //}

        private static List<String> ReadRESX(string path)
        {
            var stringResourcesList = new List<string>();
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            var rootNode = xmlDocument.SelectSingleNode("root");
            if (rootNode != null)
            {
                foreach (var xmlNode in from XmlNode xmlNode in rootNode.ChildNodes where xmlNode.NodeType.Equals(XmlNodeType.Element) where xmlNode.Name.Equals("data") where xmlNode.Attributes != null let hasTypeAttribute = xmlNode.Attributes.Cast<XmlAttribute>().Any(xmlAttribute => xmlAttribute.Name.Equals("type")) where !hasTypeAttribute select xmlNode)
                {
                    stringResourcesList.AddRange(from XmlNode childNode in xmlNode.ChildNodes where childNode.NodeType.Equals(XmlNodeType.Element) where childNode.Name.Equals("value") select childNode.InnerText);
                }
            }
            return stringResourcesList;
        }

        private static Dictionary<string, string> ReadLangFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return (from line in lines where !line.StartsWith(";") && !line.StartsWith("locale") where line.StartsWith("(") || line.StartsWith("!") select line.Split('=')).ToDictionary(splitLine => splitLine[0].Trim(), splitLine => splitLine[1].Trim());
        }  

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            comboBoxSourceLanguage.Enabled = false;
            comboBoxTargetLanguage.Enabled = false;
            textBoxSourceText.ReadOnly = true;
            textBoxTranslatedText.ReadOnly = true;
            buttonTranslate.Enabled = false;
            textBoxTranslatedText.Text = Translate(_languages[comboBoxSourceLanguage.SelectedItem.ToString()],
                                                   _languages[comboBoxTargetLanguage.SelectedItem.ToString()], textBoxSourceText.Text);

            comboBoxSourceLanguage.Enabled = true;
            comboBoxTargetLanguage.Enabled = true;
            textBoxSourceText.ReadOnly = false;
            textBoxTranslatedText.ReadOnly = false;
            buttonTranslate.Enabled = true;
            
        }

        private void TranslateLangFile(string sourceFile, string outputFile, List<string> targetLanguages, ref BackgroundWorker backgroundWorker)
        {
            var stringResources = ReadLangFile(sourceFile);
            var totalTranslations = stringResources.Count * targetLanguages.Count;
            var translationsDone = 0;
            string outputDirectory = Path.GetDirectoryName(outputFile);
            foreach (var targetLanguage in targetLanguages)
            {
                var translations = new Dictionary<string, string>();
                foreach (var stringResource in stringResources)
                {
                    translationsDone++;
                    if (translations.ContainsKey(stringResource.Key))
                        continue;
                    translations.Add(stringResource.Key, Translate("auto", targetLanguage, stringResource.Value));
                    backgroundWorker.ReportProgress((translationsDone * 100 / totalTranslations));
                }
                var langFileContents = File.ReadAllLines(sourceFile);
                var destinationFileContents = new string[langFileContents.Length];
                var lastIndex = 0;
                for (int index = 0; index < langFileContents.Length; index++)
                {
                    var langFileContent = langFileContents[index];
                    if (langFileContent.StartsWith(";"))
                    {
                        destinationFileContents[index] = langFileContent.Replace("English", (new CultureInfo(targetLanguage)).EnglishName);
                    }
                    if (langFileContent.StartsWith("locale"))
                    {
                        var parent = CultureInfo.GetCultureInfo(targetLanguage);
                        var regionalLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures)
                                                           .Where(x => x.Parent.Equals(parent));
                        destinationFileContents[index] = $"locale {String.Join(", ", regionalLanguages)}";
                    }
                    if (langFileContent.StartsWith("(") || langFileContent.StartsWith("!"))
                    {
                        lastIndex = index;
                        break;
                    }
                }
                foreach (var translation in translations)
                {
                    destinationFileContents[lastIndex] = $"{translation.Key} = {translation.Value}";
                    lastIndex++;
                }
                File.WriteAllLines(
                    $"{outputDirectory}{Path.DirectorySeparatorChar}{(new CultureInfo(targetLanguage)).EnglishName}.lang", destinationFileContents, Encoding.UTF8);
            }
        }

        private void TranslateRESXFile(string sourceFile, string outputFile, List<string> targetLanguages,
            ref BackgroundWorker backgroundWorker)
        {
            string outputFileName = Path.GetFileNameWithoutExtension(outputFile);
            string outputDirectory = Path.GetDirectoryName(outputFile);
            var stringResources = ReadRESX(sourceFile);
            var totalTranslations = stringResources.Count * targetLanguages.Count;
            var translationsDone = 0;
            foreach (var targetLanguage in targetLanguages)
            {
                var translations = new Dictionary<string, string>();
                foreach (var stringResource in stringResources)
                {
                    translationsDone++;
                    if (translations.ContainsKey($@"<value>{stringResource}</value>"))
                        continue;
                    translations.Add($@"<value>{stringResource}</value>",
                        $@"<value>{Translate("auto", targetLanguage, stringResource)}</value>");
                    backgroundWorker.ReportProgress((translationsDone * 100 / totalTranslations));
                }
                string resxFileContents = File.ReadAllText(sourceFile);
                resxFileContents = translations.Aggregate(resxFileContents, (current, translation) => current.Replace(translation.Key, translation.Value));
                File.WriteAllText(
                    $"{outputDirectory}{Path.DirectorySeparatorChar}{outputFileName}.{targetLanguage}.resx", resxFileContents, Encoding.UTF8);
            }
        }

        private void buttonTraslateResourceFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSoureFile.Text) && string.IsNullOrEmpty(textBoxOutputFile.Text))
                return;
            if (!File.Exists(textBoxSoureFile.Text))
                return;
            buttonBrowserSourceFile.Enabled = false;
            buttonBrowseOutputFile.Enabled = false;
            checkedListBoxLanguages.Enabled = false;
            buttonTraslateResourceFile.Enabled = false;
            tabControlMain.Enabled = false;
            var targetLanguages = (from object checkedLanguage in checkedListBoxLanguages.CheckedItems select _languages[checkedLanguage.ToString()]).ToList();
            var sourceFile = textBoxSoureFile.Text;
            var outputFile = textBoxOutputFile.Text;
            string outputDirectory = Path.GetDirectoryName(outputFile);
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += delegate
            {
                var fileExtension = Path.GetExtension(sourceFile);
                if (fileExtension != null)
                {
                    if (fileExtension.Equals(".lang"))
                    {
                        TranslateLangFile(sourceFile, outputFile, targetLanguages, ref backgroundWorker);
                    }
                    if (fileExtension.Equals(".resx"))
                    {
                        TranslateRESXFile(sourceFile, outputFile, targetLanguages, ref backgroundWorker);
                    }
                }
            };
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.ProgressChanged += delegate(object o, ProgressChangedEventArgs args)
                {
                    progressBarRESXTranslation.Value = args.ProgressPercentage;
                };
            backgroundWorker.RunWorkerCompleted += (o, args) =>
                {
                    progressBarRESXTranslation.Value = 100;
                    Process.Start("explorer.exe", outputDirectory);
                    buttonBrowserSourceFile.Enabled = true;
                    buttonBrowseOutputFile.Enabled = true;
                    checkedListBoxLanguages.Enabled = true;
                    buttonTraslateResourceFile.Enabled = true;
                    tabControlMain.Enabled = true;
                };
            backgroundWorker.RunWorkerAsync();
        }

        private void buttonBrowserSourceFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogSourceFile.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxSoureFile.Text = openFileDialogSourceFile.FileName;
                textBoxOutputFile.Text = saveFileDialogOutputFile.FileName = openFileDialogSourceFile.FileName;
            }
        }

        private void buttonBrowseOutputFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialogOutputFile.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxOutputFile.Text = saveFileDialogOutputFile.FileName;
            }
        }
    }
}
