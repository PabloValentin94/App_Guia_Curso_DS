﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_Etec.View.Pages.Cursos.DS
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class DS_Modulo_1 : ContentPage
    {

        public DS_Modulo_1()
        {

            InitializeComponent();

            lbl_titulo_modulo.Text = "Primeiro\nMódulo:";

        }

    }

}