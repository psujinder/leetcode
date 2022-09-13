namespace LeetCode.Problems;

public class BullsAndCows{

    public string GetHint(string secret, string guess){

        string hint = "";

        int bulls = 0;
        int cows = 0;

        List<char> secretList = new List<char>();
        List<char> guessList = new List<char>();

        secretList = secret.ToList();
        guessList = guess.ToList();

        for(int i = 0; i < guessList.Count; i++){
            if(guessList[i] == secretList[i]){
                bulls ++;
                guessList[i] = '#';
                secretList[i] = '#';
            }
        }

        for(int i = 0; i < guessList.Count; i++){
            if (guessList[i] != '#'){
                int idx = secretList.IndexOf(guessList[i]);
                if(idx != -1){
                    cows++;
                    guessList[i] = '#';
                    secretList[idx] = '#';
                }
            }
        }

        
        hint = bulls.ToString()+'A'+cows.ToString()+'B';

        return hint;

    }

}