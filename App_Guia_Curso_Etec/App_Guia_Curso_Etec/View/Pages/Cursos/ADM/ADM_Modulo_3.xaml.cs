﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia_Curso_Etec.View.Pages.Cursos.ADM
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ADM_Modulo_3 : ContentPage
    {

        public ADM_Modulo_3()
        {

            InitializeComponent();

            lbl_titulo_modulo.Text = "Terceiro\nMódulo:";

        }

    }

}