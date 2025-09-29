using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");


        List<Video> videos = new List<Video>();

        // Crear el primer video
        Video video1 = new Video("Tutorial de C# para Principiantes", "Programación Esencial", 500);
        video1.AddComment(new Comment("Juan Pérez", "¡Excelente tutorial, muy claro!"));
        video1.AddComment(new Comment("Ana Gómez", "Me ayudó a entender las clases. Gracias."));
        video1.AddComment(new Comment("Carlos Ruiz", "Estupendo. ¿Tendrán uno sobre POO?"));
        videos.Add(video1);

        // Crear el segundo video
        Video video2 = new Video("Receta de Pastel de Chocolate", "Cocina Conmigo", 360);
        video2.AddComment(new Comment("María López", "¡Lo hice y quedó delicioso!"));
        video2.AddComment(new Comment("Pedro Días", "Fácil de seguir. Me encantó."));
        video2.AddComment(new Comment("Laura Fernández", "¡Qué rico! Me anoto la receta."));
        video2.AddComment(new Comment("Jorge Torres", "Increíble. ¿Puedes hacer una de cupcakes?"));
        videos.Add(video2);

        // Crear el tercer video
        Video video3 = new Video("Explorando el Universo", "Astronomía para Todos", 1200);
        video3.AddComment(new Comment("Sofía Vargas", "Fascinante. No sabía esto sobre las estrellas."));
        video3.AddComment(new Comment("Roberto Castro", "Me encanta este tipo de contenido."));
        video3.AddComment(new Comment("Carolina Pinto", "Muy informativo. Espero más videos."));
        videos.Add(video3);

        // Iterar sobre cada video en la lista y mostrar su información
        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Título: {video._title}");
            Console.WriteLine($"Autor: {video._author}");
            Console.WriteLine($"Duración: {video._length} segundos");
            Console.WriteLine($"Número de comentarios: {video.GetNumberOfComments()}");
            Console.WriteLine("Comentarios:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  - {comment._commenterName}: \"{comment._commentText}\"");
            }

            Console.WriteLine();
        }
    }
}