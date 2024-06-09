namespace EmpyrionTranslator
{
    public class DeepLResponse
    {
        public class Translations
        {
            public string detected_source_language { get; set; }

            public string text { get; set; }

            public Translations()
            {
                detected_source_language = string.Empty;

                text = string.Empty;
            }
        }

        public Translations[] translations { get; set; }

        public DeepLResponse()
        {
            translations = new[] { new Translations() };
        }
    }
}
