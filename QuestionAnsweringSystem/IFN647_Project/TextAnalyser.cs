using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser
{
    class TextAnalyser
    {
        PorterStemmerAlgorithm.PorterStemmer myStemmer; // for Activity 4,5
        System.Collections.Generic.Dictionary<string, int> tokenCount; // for Activity 5
        public string[] stopWords = { "a", "able", "about", "above", "according", "accordingly", "across", "actually", "after", "afterwards", "again", "against", "ain't", "all", "allow", "allows", "almost", "alone", "along", "already", "also", "although", "always", "am", "among", "amongst", "an", "and", "another", "any", "anybody", "anyhow", "anyone", "anything", "anyway", "anyways", "anywhere", "apart", "appear", "appreciate", "appropriate", "are", "aren't", "around", "as", "a's", "aside", "ask", "asking", "associated", "at", "available", "away", "awfully", "be", "became", "because", "become", "becomes", "becoming", "been", "before", "beforehand", "behind", "being", "believe", "below", "beside", "besides", "best", "better", "between", "beyond", "both", "brief", "but", "by", "came", "can", "cannot", "cant", "can't", "cause", "causes", "certain", "certainly", "changes", "clearly", "c'mon", "co", "com", "come", "comes", "concerning", "consequently", "consider", "considering", "contain", "containing", "contains", "corresponding", "could", "couldn't", "course", "c's", "currently", "definitely", "described", "despite", "did", "didn't", "different", "do", "does", "doesn't", "doing", "done", "don't", "down", "downwards", "during", "each", "edu", "eg", "eight", "either", "else", "elsewhere", "enough", "entirely", "especially", "et", "etc", "even", "ever", "every", "everybody", "everyone", "everything", "everywhere", "ex", "exactly", "example", "except", "far", "few", "fifth", "first", "five", "followed", "following", "follows", "for", "former", "formerly", "forth", "four", "from", "further", "furthermore", "get", "gets", "getting", "given", "gives", "go", "goes", "going", "gone", "got", "gotten", "greetings", "had", "hadn't", "happens", "hardly", "has", "hasn't", "have", "haven't", "having", "he", "he'd", "he'll", "hello", "help", "hence", "her", "here", "hereafter", "hereby", "herein", "here's", "hereupon", "hers", "herself", "he's", "hi", "him", "himself", "his", "hither", "hopefully", "how", "howbeit", "however", "how's", "i", "i'd", "ie", "if", "ignored", "i'll", "i'm", "immediate", "in", "inasmuch", "inc", "indeed", "indicate", "indicated", "indicates", "inner", "insofar", "instead", "into", "inward", "is", "isn't", "it", "it'd", "it'll", "its", "it's", "itself", "i've", "just", "keep", "keeps", "kept", "know", "known", "knows", "last", "lately", "later", "latter", "latterly", "least", "less", "lest", "let", "let's", "like", "liked", "likely", "little", "look", "looking", "looks", "ltd", "mainly", "many", "may", "maybe", "me", "mean", "meanwhile", "merely", "might", "more", "moreover", "most", "mostly", "much", "must", "mustn't", "my", "myself", "name", "namely", "nd", "near", "nearly", "necessary", "need", "needs", "neither", "never", "nevertheless", "new", "next", "nine", "no", "nobody", "non", "none", "noone", "nor", "normally", "not", "nothing", "novel", "now", "nowhere", "obviously", "of", "off", "often", "oh", "ok", "okay", "old", "on", "once", "one", "ones", "only", "onto", "or", "other", "others", "otherwise", "ought", "our", "ours", "ourselves", "out", "outside", "over", "overall", "own", "particular", "particularly", "per", "perhaps", "placed", "please", "plus", "possible", "presumably", "probably", "provides", "que", "quite", "qv", "rather", "rd", "re", "really", "reasonably", "regarding", "regardless", "regards", "relatively", "respectively", "right", "said", "same", "saw", "say", "saying", "says", "second", "secondly", "see", "seeing", "seem", "seemed", "seeming", "seems", "seen", "self", "selves", "sensible", "sent", "serious", "seriously", "seven", "several", "shall", "shan't", "she", "she'd", "she'll", "she's", "should", "shouldn't", "since", "six", "so", "some", "somebody", "somehow", "someone", "something", "sometime", "sometimes", "somewhat", "somewhere", "soon", "sorry", "specified", "specify", "specifying", "still", "sub", "such", "sup", "sure", "take", "taken", "tell", "tends", "th", "than", "thank", "thanks", "thanx", "that", "thats", "that's", "the", "their", "theirs", "them", "themselves", "then", "thence", "there", "thereafter", "thereby", "therefore", "therein", "theres", "there's", "thereupon", "these", "they", "they'd", "they'll", "they're", "they've", "think", "third", "this", "thorough", "thoroughly", "those", "though", "three", "through", "throughout", "thru", "thus", "to", "together", "too", "took", "toward", "towards", "tried", "tries", "truly", "try", "trying", "t's", "twice", "two", "un", "under", "unfortunately", "unless", "unlikely", "until", "unto", "up", "upon", "us", "use", "used", "useful", "uses", "using", "usually", "value", "various", "very", "via", "viz", "vs", "want", "wants", "was", "wasn't", "way", "we", "we'd", "welcome", "well", "we'll", "went", "were", "we're", "weren't", "we've", "what", "whatever", "what's", "when", "whence", "whenever", "when's", "where", "whereafter", "whereas", "whereby", "wherein", "where's", "whereupon", "wherever", "whether", "which", "while", "whither", "who", "whoever", "whole", "whom", "who's", "whose", "why", "why's", "will", "willing", "wish", "with", "within", "without", "wonder", "won't", "would", "wouldn't", "yes", "yet", "you", "you'd", "you'll", "your", "you're", "yours", "yourself", "yourselves", "you've", "zero" };


        public TextAnalyser()
        {
            myStemmer = new PorterStemmerAlgorithm.PorterStemmer();
            tokenCount = new Dictionary<string, int>();
        }

        //Activity 3
        /// <summary>
        /// Convert the  given text into tokens and then splits it into tokens according to whitespace and punctuation. 
        /// </summary>
        /// <param name="text">Some text</param>
        /// <returns>Lower case tokens</returns>
        public string[] TokeniseString(string text)
        {
            char[] splitters = new char[] { ' ', '\t', '\'', '"', '-', '(', ')', ',', '’', '\n', ':', ';', '?', '.', '!' };
            return text.ToLower().Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Prints out tokens for a given text string
        /// </summary>
        /// <param name="str">a string of text</param>
        public List<string> OutputTokens(string str)
        {
            List<string> token_list = new List<string>();
            string[] tokens = TokeniseString(str);
            foreach (string t in tokens)
            {
                //System.Console.WriteLine(t);
                token_list.Add(t);
            }
            return token_list;
        }

        public string[] StemTokens(string[] tokens)
        {
            int numTokens = tokens.Count();
            string[] stems = new string[numTokens];
            for (int i = 0; i < numTokens; i++)
            {
                stems[i] = myStemmer.stemTerm(tokens[i]);
            }
            return stems;
        }

        /// <summary>
        /// Outputs stems to the sceen
        /// </summary>
        /// <param name="str">A string of text to be stemmed</param>
        public List<string> OutputStems(List<string> token_list)
        {
            List<string> stem_list = new List<string>();
            foreach (string str in token_list)
            {
                string[] tokens = TokeniseString(str);
                string[] stems = StemTokens(tokens);
                foreach (string s in stems)
                {
                    stem_list.Add(s);
                }
            }

            return stem_list;
        }

        // Activity 5
        /// <summary>
        /// Counts the occurrences of a given set of tokens
        /// </summary>
        /// <param name="tokens">An array of tokens</param>
        public void CountOccurrences(string[] tokens)
        {
            foreach (string s in tokens)
            {
                int count = 0;
                tokenCount.TryGetValue(s, out count);
                count = count + 1;
                tokenCount[s] = count;
            }
        }

        /// <summary>
        /// Displays the count of tokens to the screen
        /// </summary>
        public void DisplayCount()
        {
            foreach (var value in tokenCount)
            {
                string token = value.Key;
                int occurrences = value.Value;

                System.Console.WriteLine("Token is " + token + " number of occurrences are " + occurrences);
            }
        }

        /// <summary>
        /// Outputs occurrence count for a given string
        /// </summary>
        /// <param name="str">A string of text</param>
        public void OutputTokenCount(string str)
        {
            ResetCount();
            string[] tokens = TokeniseString(str);
            string[] stems = StemTokens(tokens);
            Console.Out.WriteLine("Orginal: " + str);
            CountOccurrences(stems);
            DisplayCount();
        }



        /// <summary>
        /// Resets the tokencount to 0
        /// </summary>
        public void ResetCount()
        {
            tokenCount.Clear();
        }




        public List<string> StopWordFilter(List<string> token_list)
        {
            int numTokens = token_list.Count();
            List<string> filteredTokens = new List<string>();
            for (int i = 0; i < numTokens; i++)
            {
                string token = token_list[i];
                if (!stopWords.Contains(token) && (token.Length > 2)) filteredTokens.Add(token);
            }
            return filteredTokens;
        }


    }
}
