namespace ListadoPersonasENT
{
    public class Persona
    {
        #region atributos
        private int id;
        private String nombre;
        private String apellido;
        private DateTime fechaNac;
        #endregion

        #region propiedades
        public int Id { 
            get { return id; } set { id = value; } 
        }

        public String Nombre{
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public String Apellido {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNac {
            get { return fechaNac;  }
            set {
                if (value.Year >= 1900) {
                    fechaNac = value; 
                }
            }
        }

        public String NombreCompleto => $"{Nombre} {Apellido}";

        public int Edad {
            get { return DateTime.Now.Year - fechaNac.Year;  }
        }

        #endregion

        #region constructores
        public Persona() { }
        /// <summary>
        /// Constructor con nombre
        /// </summary>
        /// <param name="nombre"></param>
        public Persona(String nombre) { 
            this.nombre = nombre;
        }
        /// <summary>
        /// Constructor con nombre y apellidos de persona.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(String nombre, String apellido) {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        /// <summary>
        /// Constructor con todos los parámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="fechaNac"></param>
        public Persona(int id, String nombre, String apellido, DateTime fechaNac) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
        }
        #endregion constructores
    }
}
