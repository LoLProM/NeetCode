public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dictionaryOfNums = new Dictionary<int, int>();
        List<int>[] dictionaryOfReps = new List<int>[nums.Length + 1];

        foreach (var num in nums){
            if (!dictionaryOfNums.ContainsKey(num)){
                dictionaryOfNums.Add(num, 1);
            }
            else{
                dictionaryOfNums[num]++;
            }
        }

        for (int i = 0; i < nums.Length + 1; i++) {
            dictionaryOfReps[i] = new List<int>();
        }

        foreach(var key in dictionaryOfNums.Keys){
                dictionaryOfReps[dictionaryOfNums[key]].Add(key);
        }
        
        var resultList = new List<int>();

        for (int i = dictionaryOfReps.Length - 1 ; i >= 0 ; i--){
            for (int j = 0; j < dictionaryOfReps[i].Count; j++){
                if(resultList.Count != k ){
                    resultList.Add(dictionaryOfReps[i][j]);
                }
            }
        }
        return resultList.ToArray();
    }
}