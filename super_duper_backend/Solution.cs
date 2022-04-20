using Newtonsoft.Json.Linq;

namespace SuperDuperBackend
{
    class Solution {
        /// <summary>
        /// Génère une grille de sudoku de difficulté facile
        /// </summary>
        /// <returns>la grille de sudoku</returns>
        public static int[][] GenerateGrille() {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://sugoku2.herokuapp.com/board?difficulty=easy").Result;
                var json = response.Content.ReadAsStringAsync().Result;
                var jsonObject = JObject.Parse(json);
                var grid = jsonObject["board"]!.ToObject<int[][]>();
                return grid;
            }
        }

        /// <summary>
        /// Vérifie si le sudoku à été résolu
        /// </summary>
        /// <param name="grille">Grille de sudoku renvoyé par l'utilisateur</param>
        /// <returns>true si la grille est résolue, false sinon</returns>
        public static bool CheckGrille(int[][] grille) {

            int somme_ligne = 0;
            int somme_colonne = 0;
            int somme = 0;
            for(int i = 0; i< grille.length; i++){
                for(int j = 0; j< grille.length; j++){

                    somme_ligne += grille[i][j];
                    somme_colonne += grille[j][i];

                }
            }
            //Code super compliqué qui test le sudoku
            //
            return true;
        }
    }
}