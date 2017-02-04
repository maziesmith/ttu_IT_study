using kodutöö_12.Model;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace kodutöö_12 {
    public class MarvelFacade {
        public static async Task PopulateMarvelCharactersAsync(ObservableCollection<Character> marvelCharacters) {
            try {
                var characterDataWrapper = await GetCharacterDataWrapperAsync();

                var characters = characterDataWrapper.data.results;

                foreach (var character in characters) {
                    // Filter characters that are missing thumbnail images

                    if (character.thumbnail != null && character.thumbnail.path != "" && character.thumbnail.path != Configuration.ImageNotAvailablePath) {
                        character.thumbnail.small = String.Format(
                            "{0}/standard_small.{1}",
                            character.thumbnail.path,
                            character.thumbnail.extension
                        );

                        character.thumbnail.large = String.Format(
                            "{0}/portrait_xlarge.{1}",
                            character.thumbnail.path,
                            character.thumbnail.extension
                        );

                        marvelCharacters.Add(character);
                    }
                }
            } catch (Exception) {
                return;
            }
        }

 
        public static async Task PopulateMarvelComicsAsync(int characterId, ObservableCollection<ComicBook> marvelComics) {
            try {
                var comicDataWrapper = await GetComicDataWrapperAsync(characterId);

                var comics = comicDataWrapper.data.results;

                foreach (var comic in comics) {
                    // Filter characters that are missing thumbnail images

                    if (comic.thumbnail != null && comic.thumbnail.path != "" && comic.thumbnail.path != Configuration.ImageNotAvailablePath) {
                        comic.thumbnail.small = String.Format(
                            "{0}/portrait_medium.{1}",
                            comic.thumbnail.path,
                            comic.thumbnail.extension
                        );

                        comic.thumbnail.large = String.Format(
                            "{0}/portrait_xlarge.{1}",
                            comic.thumbnail.path,
                            comic.thumbnail.extension
                        );

                        marvelComics.Add(comic);
                    }
                }
            } catch (Exception) {
                return;
            }
        }

        private static async Task<CharacterDataWrapper> GetCharacterDataWrapperAsync() {
            // Assemble the URL
            Random random = new Random();
            var offset = random.Next(Configuration.MaxCharacters);

            string url = $"http://gateway.marvel.com:80/v1/public/characters?limit=10&offset={offset}";

            var jsonMessage = await CallMarvelAsync(url);

            // Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(CharacterDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (CharacterDataWrapper)serializer.ReadObject(ms);
            return result;
        }

        private static async Task<ComicDataWrapper> GetComicDataWrapperAsync(int characterId) {
            var url = $"http://gateway.marvel.com:80/v1/public/comics?characters={characterId}&limit=10";

            var jsonMessage = await CallMarvelAsync(url);

            // Response -> string / json -> deserialize
            var serializer = new DataContractJsonSerializer(typeof(ComicDataWrapper));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonMessage));

            var result = (ComicDataWrapper)serializer.ReadObject(ms);
            return result;
        }

        private async static Task<string> CallMarvelAsync(string url) {
            // Get the MD5 Hash
            var timeStamp = DateTime.Now.Ticks.ToString();
            var hash = CreateHash(timeStamp);

            string completeUrl = String.Format("{0}&apikey={1}&ts={2}&hash={3}", url, Configuration.PublicKey, timeStamp, hash);

            // Call out to Marvel
            HttpClient http = new HttpClient();
            var response = await http.GetAsync(completeUrl);
            return await response.Content.ReadAsStringAsync();
        }

        private static string CreateHash(string timeStamp) {
            string toBeHashed = timeStamp + Configuration.PrivateKey + Configuration.PublicKey;
            string hashedMessage = MD5Hash.Compute(toBeHashed);
            return hashedMessage;
        }
    }
}
