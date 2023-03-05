using System;
using System.Collections.Generic;
using System.Linq;
class Program {
    static void Main() {
        //Replace, replaces all characters that are not a-z or A-Z with empty space
        string text = GetText().Replace("[^a-zA-Z ]", "");

        //this line takes takes and splits it into an array of words with a space or " " as the separator
        string[] words = text.Split(" ");

        //make a new dictonary that takes in a string, and int as key/value pairs
        Dictionary<string, int> freqCounts = new Dictionary<string, int>();

//loop through each word in wors array
        foreach (string word in words) {
            //if program encounters a space 
            //continue
            if (word.Trim() == "") {
                continue;
            }
        //if freqcount containers word, increment current words count by one
            if (freqCounts.ContainsKey(word)) {
                freqCounts[word] += 1;
            } else {
                freqCounts[word] = 1;
            }
        }

//for each kvp entry in freqcounts
//write the key
//and the int value
        foreach (KeyValuePair<string, int> entry in freqCounts) {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }

//The static keyword is useful for creating functions or variables that are global in scope and don't depend on the state of any specific instance of the class. 
    static string GetText() {
        return @"
            Look again at that dot. That's here. That's home. That's us. On it everyone you love, everyone you know, everyone you ever heard of, every human being who ever was, lived out their lives. The aggregate of our joy and suffering, thousands of confident religions, ideologies, and economic doctrines, every hunter and forager, every hero and coward, every creator and destroyer of civilization, every king and peasant, every young couple in love, every mother and father, hopeful child, inventor and explorer, every teacher of morals, every corrupt politician, every ""superstar,"" every ""supreme leader,"" every saint and sinner in the history of our species lived there--on a mote of dust suspended in a sunbeam.

            The Earth is a very small stage in a vast cosmic arena. Think of the rivers of blood spilled by all those generals and emperors so that, in glory and triumph, they could become the momentary masters of a fraction of a dot. Think of the endless cruelties visited by the inhabitants of one corner of this pixel on the scarcely distinguishable inhabitants of some other corner, how frequent their misunderstandings, how eager they are to kill one another, how fervent their hatreds.

            Our posturings, our imagined self-importance, the delusion that we have some privileged position in the Universe, are challenged by this point of pale light. Our planet is a lonely speck in the great enveloping cosmic dark. In our obscurity, in all this vastness, there is no hint that help will come from elsewhere to save us from ourselves.

            The Earth is the only world known so far to harbor life. There is nowhere else, at least in the near future, to which our species could migrate. Visit, yes. Settle, not yet. Like it or not, for the moment the Earth is where we make our stand.

            It has been said that astronomy is a humbling and character-building experience. There is perhaps no better demonstration of the folly of human conceits than this distant image of our tiny world. To me, it underscores our responsibility to deal more kindly with one another, and to preserve and cherish the pale blue dot, the only home we've ever known.
              - Carl Sagan";
    }
}
