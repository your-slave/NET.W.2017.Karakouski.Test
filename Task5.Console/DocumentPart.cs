namespace Task5.Console
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        public abstract string ToHtml();

        public abstract string ToPlainText();

        public abstract string ToLaTeX();
    }
}
