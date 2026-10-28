// public class Linkedlist_NativeExamples
// {
//     public static void Main()
//     {
//         // 1. Initialize the linked list
//         LinkedList<string> playlist = new LinkedList<string>();

//         // 2. Add elements
//         playlist.AddLast("Song A");
//         playlist.AddLast("Song B");
//         playlist.AddFirst("Intro Track");

//         // 3. Find a specific node and insert after it
//         LinkedListNode<string> currentSong = playlist.Find("Song A");
//         if (currentSong != null)
//         {
//             playlist.AddAfter(currentSong, "Interlude");
//         }

//         // 4. Remove an element
//         playlist.Remove("Song B");

//         // 5. Traverse and print the list
//         foreach (string song in playlist)
//         {
//             Console.WriteLine(song);
//         }
//         // Output:
//         // Intro Track
//         // Song A
//         // Interlude
//     }
// }
