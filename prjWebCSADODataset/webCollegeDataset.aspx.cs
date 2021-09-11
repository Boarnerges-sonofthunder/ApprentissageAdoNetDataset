using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace prjWebCSADODataset
{
    public partial class webCollegeDataset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                DataSet myset = creerDataset();//appel de la fonction creerDataset
                gridTable.DataSource = myset.Tables["Etudiants"];// Ajout de la table cours avec le gridtable
                gridTable.DataBind();//liaison de la gridtable

                foreach (DataRow row in myset.Tables[0].Rows)
                {
                    lstNumero.Items.Add(row["Numero"].ToString());
                }
            }
            
        }
        private static DataSet creerDataset()
        {
            //Creation d'un Dataset
            DataSet setCollege = new DataSet();

            //Creation de la DataTable cours
            DataTable myTb = new DataTable("Cours");

            //Creation de la colonne RefCours
            DataColumn myCol = new DataColumn("RefCours",Type.GetType("System.Int32"));
            myCol.AutoIncrement = true;
            myCol.AutoIncrementSeed = 1;
            myCol.AutoIncrementStep = 1;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne mumero
            myCol = new DataColumn("Numero", typeof(String));
            myCol.MaxLength = 15;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne titre
            myCol = new DataColumn("Titre", typeof(String));
            myCol.MaxLength = 250;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne professeur
            myCol = new DataColumn("Professeur", typeof(String));
            myCol.MaxLength = 50;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne duree
            myCol = new DataColumn("Duree", typeof(Int32));
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation d'un tableau de type DataColumn pour mettre les cles primaires
            DataColumn[] keys = new DataColumn[1];
            keys[0] = myTb.Columns["RefCours"];
            //Ajout de la cles primaire dans le tableau
            myTb.PrimaryKey = keys;

            //Ajouter la table dans le DataSet
            setCollege.Tables.Add(myTb);

            //Remplir la table cours avec quelque enregistrement sinon le gridview ne s'affiche pas
            myTb = setCollege.Tables["Cours"];
            //Pour creer un Datarow il faut qu'il y est une table qui existe deja alors on ne peut pas faire new DataRow
            DataRow myRow = myTb.NewRow();
            //On entre les colonnes sauf celui qui est autonumber(RefCours)
            myRow["Numero"] = "420-POO-TT";
            myRow["Titre"] = "Programmation Orientee Objet";
            myRow["Professeur"] = "Fode Toure";
            myRow["Duree"] = 90;
            //Ajoute dans la table
            myTb.Rows.Add(myRow);

            myRow = myTb.NewRow();
            myRow["Numero"] = "420-ALG-TT";
            myRow["Titre"] = "Introduction a l'algorithmique";
            myRow["Professeur"] = "Mohamed Mefla";
            myRow["Duree"] = 60;
            //Ajoute dans la table
            myTb.Rows.Add(myRow);

            
            //Creation de la DataTable etudiants
            myTb = new DataTable("Etudiants");

            //Creation de la colonne RefCours
            myCol = new DataColumn("RefEtudiant", typeof(Int32));
            myCol.AutoIncrement = true;
            myCol.AutoIncrementSeed = 1;
            myCol.AutoIncrementStep = 1;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne nom
            myCol = new DataColumn("Nom", typeof(String));
            myCol.MaxLength = 15;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne Naissance
            myCol = new DataColumn("Naissance", typeof(DateTime));
            myCol.DefaultValue = DateTime.Today;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne moyenne
            myCol = new DataColumn("Moyenne", typeof(Single));
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne email
            myCol = new DataColumn("Email", typeof(String));
            myCol.MaxLength = 50;
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation de la colonne referCours
            myCol = new DataColumn("ReferCours", typeof(Int32));
            //Ajouter le champs a la table
            myTb.Columns.Add(myCol);

            //Creation d'un tableau de type DataColumn pour mettre les cles primaires
            keys = new DataColumn[1];
            keys[0] = myTb.Columns["RefEtudiant"];
            //Ajout de la cles primaire dans le tableau
            myTb.PrimaryKey = keys;

            //Ajouter la table dans le DataSet
            setCollege.Tables.Add(myTb);

            //Remplir la table cours avec quelque enregistrement sinon le gridview ne s'affiche pas
            myTb = setCollege.Tables["Etudiants"];
            //Pour creer un Datarow il faut qu'il y est une table qui existe deja alors on ne peut pas faire new DataRow
            myRow = myTb.NewRow();
            myRow["Nom"] = "Luri Strife";
            myRow["Naissance"] = new DateTime(1995, 4, 6);
            myRow["Moyenne"] = 90;
            myRow["Email"] = "StrifeL@hotmail.com";
            myRow["ReferCours"] = 1;
            myTb.Rows.Add(myRow);

            myRow = myTb.NewRow();
            myRow["Nom"] = "Lightning Bolt";
            myRow["Naissance"] = new DateTime(1990, 6, 4);
            myRow["Moyenne"] = 80;
            myRow["Email"] = "BoltL@hotmail.com";
            myRow["ReferCours"] = 2;
            myTb.Rows.Add(myRow);

            return setCollege;
        }

        protected void lstNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet myset = creerDataset();

            txtNumero.Text = myset.Tables[0].Rows["Numero"];
            
            
            

        }
    }
}