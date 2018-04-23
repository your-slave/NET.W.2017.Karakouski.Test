namespace Task5.Console
{
    public class BoldText : DocumentPart
    {
        public override string ToHtml() => "<b>" + this.Text + "</b>";

        public override string ToPlainText() => "**" + this.Text + "**";

        public override string ToLaTeX() => "\\textbf{" + this.Text + "}";
    }
}