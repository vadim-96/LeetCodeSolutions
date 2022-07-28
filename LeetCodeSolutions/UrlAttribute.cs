namespace LeetCodeSolutions;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
internal class UrlAttribute : Attribute
{
    public UrlAttribute(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            throw new ArgumentNullException(nameof(url));
        }

        this.Url = url;
    }

    public string Url { get; private set; }
}
