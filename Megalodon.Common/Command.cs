using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Megalodon.Common
{


    public class Command
    {
        private IDictionary<string, JToken> _commandParameters = new JObject();


        public Command(string name, IDictionary<string, JToken> parameters)
        {
            this.Name = name;
            if (parameters != null)
            {
                this.Parameters = parameters;
            }
        }

        public Command(string name, string jsonParameters)
            : this(name, string.IsNullOrEmpty(jsonParameters) ? null : JObject.Parse(jsonParameters))
        {
        }

        public Command(string name)
        {
            this.Name = name;
        }

        public Command()
        {
        }


        /// <summary>
        /// Gets the command name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the parameters of the command
        /// </summary>
        [JsonProperty("parameters")]
        public IDictionary<string, JToken> Parameters
        {
            get { return this._commandParameters; }

            set { this._commandParameters = value; }
        }

        /// <summary>
        /// Gets the SessionID of the command
        /// </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }
}