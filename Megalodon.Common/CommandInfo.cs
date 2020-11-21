namespace Megalodon.Common
{
    public class CommandInfo
    {
        #region Constants

        public const string DeleteCommand = "DELETE";

        public const string GetCommand = "GET";

        public const string PostCommand = "POST";

        #endregion


        public CommandInfo(string method, string resourcePath)
        {
            this.ResourcePath = resourcePath;
            this.Method = method;
        }



        public string Method { get; set; }

        public string ResourcePath { get; set; }

    }
}
