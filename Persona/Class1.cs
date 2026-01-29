namespace IntroduccionCSharp.Persona.Ejemplos
{ 
    public class Persona
    {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Genero { get; set; }
            public int Edad { get; set; }
            //Metodo: constructor
            /*
            1. Se llama igual que la clase
            2. No retorna datos
            3. Se utiliza para inicializar valores de propiedades de la clase
            4. se ejecuta cuando se construye el objeto
            5. No se puede llamar por medio de la sintaxis de punto

            */
            public Persona(string nombres,string apellidos,string genero,int edad)
            {
                Nombre = nombres;
                Apellido = apellidos;
                Genero = genero;
                Edad = edad;

            }

    }   
}