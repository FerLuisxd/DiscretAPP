using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiscretAPP7.Views
{
    
    using ViewModels;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisPage : ContentPage
    {
        
        Label semaa;
        Label pippo;
        Button VSemA;
        Button VSemS;
        Label a;
        Label b;
        int sem;
        public DisPage()
        {
            InitializeComponent();
            asd();
           
        }
        public DisPage(int semana)
        {
            InitializeComponent();
            asd();
            sem = semana;
        }
        private void asd()
        {
            VSemA = this.FindByName<Button>("BSemA");
            VSemS = this.FindByName<Button>("BSemS");
            pippo = this.FindByName<Label>("notLabel");
            S1C1 = this.FindByName<Label>("S1C1");
            S1C2 = this.FindByName<Label>("S1C2");
            S1C3 = this.FindByName<Label>("S1C3");
            S2C1 = this.FindByName<Label>("S2C1");
            S2C2 = this.FindByName<Label>("S2C2");
            S2C3 = this.FindByName<Label>("S2C3");
            SVC1 = this.FindByName<Label>("SVC1");
            SVC2 = this.FindByName<Label>("SVC2");
            SVC3 = this.FindByName<Label>("SVC3");
            a = this.FindByName<Label>("no1");
            b = this.FindByName<Label>("no2");
            //pippo.Text = DateTime.Now.ToString();
            pippo.Text = Infrastructure.Settings.LastUsedSec;
            DateTime dtOne = new System.DateTime(2018, 3, 19);
            DateTime two = DateTime.Now;
            double answer = (two - dtOne).TotalDays;
            sem = ((int)answer / 7) + 1;
            semaa = this.FindByName<Label>("Semana");
            semaa.Text = "Semana : " + sem.ToString();
            if (sem == 8) semaa.Text = "Semana : " + sem.ToString() + " Parcial";
        }
        protected void SemS(object sender, EventArgs e)
        {
            if (sem < 16)
            {
                sem++;
                semaa.Text = "Semana : " + sem.ToString();
                if (sem == 1)
                {
                    S1C1.Text = "Indicaciones generales";
                    S1C2.Text = "Conjuntos";
                    S1C3.Text = "";
                    S2C1.Text = "División en los enteros";
                    S2C2.Text = "Actividad Colaborativa 1";
                    S2C3.Text = "";
                    SVC1.Text = "Matrices Booleanas";
                    SVC2.Text = "Tarea 1";
                    SVC3.Text = "Evaluación Virtual 1";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 2)
                {
                    S1C1.Text = "Matrices Booleanas";
                    S1C2.Text = "Lógica proposicional";
                    S1C3.Text = "";
                    S2C1.Text = "Cuantificadores";
                    S2C2.Text = "Actividad Colaborativa 2";
                    S2C3.Text = "";
                    SVC1.Text = "Inducción Matemática";
                    SVC2.Text = "Tarea 2";
                    SVC3.Text = "Evaluación Virtual 2";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 3)
                {
                    S1C1.Text = "Inducción Matemática";
                    S1C2.Text = "Algoritmos";
                    S1C3.Text = "";
                    S2C1.Text = "Sucesiones";
                    S2C2.Text = "Sucesiones recurrentes";
                    S2C3.Text = "Actividad Colaborativa 3";
                    SVC1.Text = "Relaciones: Definición, representación";
                    SVC2.Text = "Videoconferencia PC1";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 4)
                {
                    S1C1.Text = "Práctica Calificada 1";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "Relaciones: Definición, representación";
                    S2C2.Text = "Relaciones: Propiedades";
                    S2C3.Text = "Actividad Colaborativa 4";
                    SVC1.Text = "Relaciones: Manipulación";
                    SVC2.Text = "Tarea 3";
                    SVC3.Text = "Evaluación Virtual 3";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 5)
                {
                    S1C2.Text = "Relaciones: Manipulación";
                    S1C3.Text = "Funciones: Definición, tipos";
                    S2C1.Text = "";
                    S2C2.Text = "Funciones de permutación";
                    S2C3.Text = "Actividad Colaborativa 5";
                    SVC1.Text = "Estructuras de orden: Definición, diagrama de Hasse";
                    SVC2.Text = "Tarea 4";
                    SVC3.Text = "Evaluación Virtual 4";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 6)
                {
                    S1C1.Text = "Estructuras de orden: Definición, diagrama de Hasse";
                    S1C2.Text = "Estructuras de orden: Elementos extremos, cotas";
                    S1C3.Text = "";
                    S2C1.Text = "Retículas: Definición, tipos";
                    S2C2.Text = "Actividad colaborativa 6";
                    S2C3.Text = "";
                    SVC1.Text = "Álgebra de Boole: Definición, propiedades";
                    SVC2.Text = "Tarea 5";
                    SVC3.Text = "Evaluación Virtual 5";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 7)
                {
                    S1C1.Text = "Álgebra de Boole: Definición, propiedades";
                    S1C2.Text = "Clase integral";
                    S1C3.Text = "";
                    S2C1.Text = "Clase integral";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 8)
                {
                    S1C1.Text = "Matriz de habilidades";
                    S1C2.Text = "Exámenes Parciales pasados";
                    S1C3.Text = "";
                    S2C1.Text = "";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    semaa.Text = "Semana : " + sem.ToString() + " Parcial";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 9)
                {
                    S1C1.Text = "Funciones booleanas";
                    S1C2.Text = "Mapas de Karnaugh";
                    S1C3.Text = "";
                    S2C1.Text = "Funciones booleanas en contextos reales";
                    S2C2.Text = "Revisión del avance del Trabajo Final";
                    S2C3.Text = "Actividad colaborativa 7";
                    SVC1.Text = "Árboles dirigidos";
                    SVC2.Text = "Tarea 6";
                    SVC3.Text = "Evaluación Virtual 6";
                    a.Text = "";
                    b.Text = "";
                }

                if (sem == 10)
                {
                    S1C1.Text = "Árboles dirigidos";
                    S1C2.Text = "Búsqueda en árboles";
                    S1C3.Text = "";
                    S2C1.Text = "Árboles no dirigidos";
                    S2C2.Text = "Actividad colaborativa 8";
                    S2C3.Text = "";
                    SVC1.Text = "Espacio Euclidiano";
                    SVC2.Text = "Tarea 7";
                    SVC3.Text = "Evaluación Virtual 7";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 11)
                {
                    S1C1.Text = "Espacio Euclidiano";
                    S1C2.Text = "Combinación lineal";
                    S1C3.Text = "Independencia lineal";
                    S2C1.Text = "Base de un espacio vectorial";
                    S2C2.Text = "Coordenadas de un vector";
                    S2C3.Text = "Actividad colaborativa 9";
                    SVC1.Text = "Guía del alumno";
                    SVC2.Text = "Cambio de base";
                    SVC3.Text = "Videoconferencia PC2";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 12)
                {
                    S1C1.Text = "Práctica Calificada 2";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "Cambio de base";
                    S2C2.Text = "Revisión del avance del trabajo final";
                    S2C3.Text = "";
                    SVC1.Text = "Guía del alumno";
                    SVC2.Text = "Transformaciones Lineales";
                    SVC3.Text = "Evaluación Virtual 8";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 13)
                {
                    S1C1.Text = "Transformaciones lineales";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "Núcleo e imagen de una transformación lineal";
                    S2C2.Text = "Actividad colaborativa 9";
                    S2C3.Text = "";
                    SVC1.Text = "Autovalores. Autovectores";
                    SVC2.Text = "Tarea 9";
                    SVC3.Text = "Evaluación Virtual 9";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 14)
                {
                    S1C1.Text = "Retroalimentación: Autovectores y Autovalores";
                    S1C2.Text = "Tema: Cadena de Markov";
                    S1C3.Text = "Ejercicios en Clase: Cadena de Markov";
                    S2C1.Text = "Tema: Cadena de Markov";
                    S2C2.Text = "Ejercicios en Clase: Cadena de Markov";
                    S2C3.Text = "Problemas Resueltos: Cadena de Markov 1 y 2";
                    SVC1.Text = "Clase Integral - EB";
                    SVC2.Text = "Enlace para subir la Tarea 10";
                    SVC3.Text = "Evaluacion Virtual 10";
                    a.Text = "* Inicio: miércoles 20 de junio a las 0 h";
                    b.Text = " * Fin: domingo 24 de junio a las 24 h";
                }
                if (sem == 15)
                {
                    S1C1.Text = "";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 16)
                {
                    S1C1.Text = "";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
            }


           
        }
       
        private void ShowPopupPC(object o, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PopUpView(1));
        }


        protected void SemA(object sender, EventArgs e)
        {
            if (sem > 1)
            {
                sem--;
                semaa.Text = "Semana : " + sem.ToString();
                if (sem == 1)
                {
                    S1C1.Text = "Indicaciones generales";
                    S1C2.Text = "Conjuntos";
                    S1C3.Text = "";
                    S2C1.Text = "División en los enteros";
                    S2C2.Text = "Actividad Colaborativa 1";
                    S2C3.Text = "";
                    SVC1.Text = "Matrices Booleanas";
                    SVC2.Text = "Tarea 1";
                    SVC3.Text = "Evaluación Virtual 1";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 2)
                {
                    S1C1.Text = "Matrices Booleanas";
                    S1C2.Text = "Lógica proposicional";
                    S1C3.Text = "";
                    S2C1.Text = "Cuantificadores";
                    S2C2.Text = "Actividad Colaborativa 2";
                    S2C3.Text = "";
                    SVC1.Text = "Inducción Matemática";
                    SVC2.Text = "Tarea 2";
                    SVC3.Text = "Evaluación Virtual 2";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 3)
                {
                    S1C1.Text = "Inducción Matemática";
                    S1C2.Text = "Algoritmos";
                    S1C3.Text = "";
                    S2C1.Text = "Sucesiones";
                    S2C2.Text = "Sucesiones recurrentes";
                    S2C3.Text = "Actividad Colaborativa 3";
                    SVC1.Text = "Relaciones: Definición, representación";
                    SVC2.Text = "Videoconferencia PC1";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 4)
                {
                    S1C1.Text = "Práctica Calificada 1";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "Relaciones: Definición, representación";
                    S2C2.Text = "Relaciones: Propiedades";
                    S2C3.Text = "Actividad Colaborativa 4";
                    SVC1.Text = "Relaciones: Manipulación";
                    SVC2.Text = "Tarea 3";
                    SVC3.Text = "Evaluación Virtual 3";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 5)
                {
                    S1C2.Text = "Relaciones: Manipulación";
                    S1C3.Text = "Funciones: Definición, tipos";
                    S2C1.Text = "";
                    S2C2.Text = "Funciones de permutación";
                    S2C3.Text = "Actividad Colaborativa 5";
                    SVC1.Text = "Estructuras de orden: Definición, diagrama de Hasse";
                    SVC2.Text = "Tarea 4";
                    SVC3.Text = "Evaluación Virtual 4";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 6)
                {
                    S1C1.Text = "Estructuras de orden: Definición, diagrama de Hasse";
                    S1C2.Text = "Estructuras de orden: Elementos extremos, cotas";
                    S1C3.Text = "";
                    S2C1.Text = "Retículas: Definición, tipos";
                    S2C2.Text = "Actividad colaborativa 6";
                    S2C3.Text = "";
                    SVC1.Text = "Álgebra de Boole: Definición, propiedades";
                    SVC2.Text = "Tarea 5";
                    SVC3.Text = "Evaluación Virtual 5";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 7)
                {
                    S1C1.Text = "Álgebra de Boole: Definición, propiedades";
                    S1C2.Text = "Clase integral";
                    S1C3.Text = "";
                    S2C1.Text = "Clase integral";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 8)
                {
                    S1C1.Text = "Matriz de habilidades";
                    S1C2.Text = "Exámenes Parciales pasados";
                    S1C3.Text = "";
                    S2C1.Text = "";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    semaa.Text = "Semana : " + sem.ToString() + " Parcial";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 9)
                {
                    S1C1.Text = "Funciones booleanas";
                    S1C2.Text = "Mapas de Karnaugh";
                    S1C3.Text = "";
                    S2C1.Text = "Funciones booleanas en contextos reales";
                    S2C2.Text = "Revisión del avance del Trabajo Final";
                    S2C3.Text = "Actividad colaborativa 7";
                    SVC1.Text = "Árboles dirigidos";
                    SVC2.Text = "Tarea 6";
                    SVC3.Text = "Evaluación Virtual 6";
                    a.Text = "";
                    b.Text = "";
                }

                if (sem == 10)
                {
                    S1C1.Text = "Árboles dirigidos";
                    S1C2.Text = "Búsqueda en árboles";
                    S1C3.Text = "";
                    S2C1.Text = "Árboles no dirigidos";
                    S2C2.Text = "Actividad colaborativa 8";
                    S2C3.Text = "";
                    SVC1.Text = "Espacio Euclidiano";
                    SVC2.Text = "Tarea 7";
                    SVC3.Text = "Evaluación Virtual 7";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 11)
                {
                    S1C1.Text = "Espacio Euclidiano";
                    S1C2.Text = "Combinación lineal";
                    S1C3.Text = "Independencia lineal";
                    S2C1.Text = "Base de un espacio vectorial";
                    S2C2.Text = "Coordenadas de un vector";
                    S2C3.Text = "Actividad colaborativa 9";
                    SVC1.Text = "Guía del alumno";
                    SVC2.Text = "Cambio de base";
                    SVC3.Text = "Videoconferencia PC2";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 12)
                {
                    S1C1.Text = "Práctica Calificada 2";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "Cambio de base";
                    S2C2.Text = "Revisión del avance del trabajo final";
                    S2C3.Text = "";
                    SVC1.Text = "Guía del alumno";
                    SVC2.Text = "Transformaciones Lineales";
                    SVC3.Text = "Evaluación Virtual 8";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 13)
                {
                    S1C1.Text = "Transformaciones lineales";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "Núcleo e imagen de una transformación lineal";
                    S2C2.Text = "Actividad colaborativa 9";
                    S2C3.Text = "";
                    SVC1.Text = "Autovalores. Autovectores";
                    SVC2.Text = "Tarea 9";
                    SVC3.Text = "Evaluación Virtual 9";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 14)
                {
                    S1C1.Text = "Autovalores. Autovectores";
                    S1C2.Text = "Cadena de Markov";
                    S1C3.Text = "";
                    S2C1.Text = "Cadena de Markov.";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "Clase Integradora";
                    SVC2.Text = "Tarea 10";
                    SVC3.Text = "Evaluación Virtual 10";
                    a.Text = "* Inicio: miércoles 20 de junio a las 0 h";
                    b.Text = " * Fin: domingo 24 de junio a las 24 h";
                }
                if (sem == 15)
                {
                    S1C1.Text = "";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
                if (sem == 16)
                {
                    S1C1.Text = "";
                    S1C2.Text = "";
                    S1C3.Text = "";
                    S2C1.Text = "";
                    S2C2.Text = "";
                    S2C3.Text = "";
                    SVC1.Text = "";
                    SVC2.Text = "";
                    SVC3.Text = "";
                    a.Text = "";
                    b.Text = "";
                }
            }
        
        }
        protected void GoLink1(object sender, EventArgs e)
        {
            if (sem == 1) { Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130053_1")); }
            if (sem == 2) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130043_1"));  }
            if (sem == 3) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130071_1"));  }
            if (sem == 4) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130015_1"));  }
            if (sem == 5) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130083_1"));  }
            if (sem == 6) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130078_1"));  }
            if (sem == 7) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130021_1"));  }
            if (sem == 8) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130076_1"));  }
            if (sem == 9) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130061_1"));  }
            if (sem == 10){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130087_1")); }
            if (sem == 11){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130067_1")); }
            if (sem == 12){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130025_1")); }
            if (sem == 13){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130057_1"));      }
            if (sem == 14) { Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130036_1m")); }
            if (sem == 15) { }
            if(sem == 16) { }
           
        }
        protected void GoLink2(object sender, EventArgs e)
        {
            if(sem == 1)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130054_1")); }
            if (sem == 2) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130044_1")); }
            if (sem == 3) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130072_1")); }
            if (sem == 4) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130016_1")); }
            if (sem == 5) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130084_1")); }
            if (sem == 6) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130079_1")); }
            if (sem == 7) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130022_1")); }
            if (sem == 8) {                                                                                                                                                 }
            if(sem == 9)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130062_1")); }
            if (sem == 10){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130088_1"));}
            if (sem == 11){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130068_1"));}
            if (sem == 12){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130026_1"));}
            if (sem == 13){ Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130058_1"));}
            if (sem == 14) { Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130037_1")); }
            if (sem == 15) { }
            if(sem == 16) { }
          
        }
        protected void GoLink3(object sender, EventArgs e)
        {
            if(sem == 1)   {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130055_1"));   }
            if (sem == 2)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130045_1"));   }
            if (sem == 3)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130073_1"));   }
            if (sem == 4)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130017_1"));   }
            if (sem == 5)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130085_1"));   }
            if (sem == 6)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130080_1"));   }
            if (sem == 7)  {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130023_1"));   }
            if (sem == 8)  {                                                                                                                                                   }
            if(sem == 9)   {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130064_1"));   }
            if (sem == 10) { Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130089_1"));  }
            if (sem == 11) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130069_1"));   }
            if (sem == 12) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130027_1"));   }
            if (sem == 13) {Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130059_1"));   }
            if (sem == 14) { Device.OpenUri(new Uri("https://aulavirtual.upc.edu.pe/webapps/blackboard/content/listContent.jsp?course_id=_148821_1&content_id=_11130038_1")); }
            if (sem == 15) { }
            if(sem == 16) { }
           
        }
        protected void Next(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new CalcPage());
        }
        protected void LogOut(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new BuscarView());
        }
    }
}