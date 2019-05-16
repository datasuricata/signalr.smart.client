using Newtonsoft.Json;

namespace SinalSmartCli {
    public static class Helpers {
        public static string ToJson(this object obj) {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
