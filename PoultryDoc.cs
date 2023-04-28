using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computerized_Poultry_Farm
{
    public partial class PoultryDoc : Form
    {
        int progress = 0;
        
        public PoultryDoc()
        {
            InitializeComponent();
        }

        private void BtnChecker_Click(object sender, EventArgs e)
        {
            panelResult.Visible = true;


            // Building medical Centre
            StringBuilder MessageBuilder = new StringBuilder();
            StringBuilder MessageBuilder2 = new StringBuilder();
            StringBuilder MessageBuilder3 = new StringBuilder();

            if (comboSymptom.Text == "Strains")
            {
                timer1.Start();
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Colibacillosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(Coliform Infections)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing adequate ventilation");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Good litter and range conditions");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Properly cleaned and disinfected equipment");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 high quality feed and water will improve the ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("disease resisting status of the birds.");
                MessageBuilder2.Append(Environment.NewLine);
                //6
                MessageBuilder2.Append("\t\u2022 Always avoid overcrowding & over heating ");
                MessageBuilder2.Append(Environment.NewLine);
                //7
                MessageBuilder2.Append("\t\u2022 Avoid vaccination");
                MessageBuilder2.Append(Environment.NewLine);

                labelRecommendation.Text = MessageBuilder2.ToString(); 

            }

            //Phase Two

            if (comboSymptom.Text == "Respiratory Issue")
            {
                
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Mycoplasmosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(CRD, Air Sac, Sinustis)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing high levels of spectrum antibiotics");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Using (Tylosin, aureomycin, terramycin, gallimycin)");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("either in feed, drinking water or by injections.");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 The upper form of infectious sinusitis can be ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("  treated with success by injecting antibiotics into ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  the swollen sinus cavity.");
                //6
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase Three

            if (comboSymptom.Text == "Air Sac Issue")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Mycoplasmosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(CRD, Air Sac, Sinustis)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing high levels of spectrum antibiotics");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Using (Tylosin, aureomycin, terramycin, gallimycin)");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("either in feed, drinking water or by injections.");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 The upper form of infectious sinusitis can be ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("  treated with success by injecting antibiotics into ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  the swollen sinus cavity.");
                //6
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //phase four

            if (comboSymptom.Text == "Dehydration")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Colibacillosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(Coliform Infections)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing adequate ventilation");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Good litter and range conditions");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Properly cleaned and disinfected equipment");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 high quality feed and water will improve the ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("disease resisting status of the birds.");
                MessageBuilder2.Append(Environment.NewLine);
                //6
                MessageBuilder2.Append("\t\u2022 Always avoid overcrowding & over heating ");
                MessageBuilder2.Append(Environment.NewLine);
                //7
                MessageBuilder2.Append("\t\u2022 Avoid vaccination");
                MessageBuilder2.Append(Environment.NewLine);

                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase Five

            if (comboSymptom.Text == "Swelling")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Colibacillosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(Coliform Infections)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing adequate ventilation");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Good litter and range conditions");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Properly cleaned and disinfected equipment");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 high quality feed and water will improve the ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("disease resisting status of the birds.");
                MessageBuilder2.Append(Environment.NewLine);
                //6
                MessageBuilder2.Append("\t\u2022 Always avoid overcrowding & over heating ");
                MessageBuilder2.Append(Environment.NewLine);
                //7
                MessageBuilder2.Append("\t\u2022 Avoid vaccination");
                MessageBuilder2.Append(Environment.NewLine);

                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase Six

            if (comboSymptom.Text == "Low Egg Production")
            {
                MessageBuilder3.Append("\t\u2022 Bacterial Disease");
                MessageBuilder3.Append(Environment.NewLine);
                //2
                MessageBuilder3.Append("\t\u2022 Parasitic Disease");
                MessageBuilder3.Append(Environment.NewLine);
                MessageBuilder3.Append("\t\u2022 Viral Disease");
                //3
                MessageBuilder2.Append("\t\u2022 Properly cleaned and disinfected equipment");
                MessageBuilder2.Append(Environment.NewLine);
                Labelfactor.Text = MessageBuilder3.ToString();
                MessageBuilder.Append("Pullorum Disease");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Cecal Worm");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Avian Pox");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append(" The following drugs can be used");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 furazolidone");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 gentamycin sulfate");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 and sulfa drugs (sulfadimethoxine, sulfamethazine,");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append(" and sulfamerazine).");
               

                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase Seven

            if (comboSymptom.Text == "High mortality")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Ulcerative Enteritis ");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(Quail disease)");
               
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append(" The following drugs can be used");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Bacitracin");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 penicillin");
                MessageBuilder2.Append(Environment.NewLine);
                //4
               

                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase Eight

            if (comboSymptom.Text == "Low Feed Efficiency")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Colibacillosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(Coliform Infections)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing adequate ventilation");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Good litter and range conditions");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Properly cleaned and disinfected equipment");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 high quality feed and water will improve the ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("disease resisting status of the birds.");
                MessageBuilder2.Append(Environment.NewLine);
                //6
                MessageBuilder2.Append("\t\u2022 Always avoid overcrowding & over heating ");
                MessageBuilder2.Append(Environment.NewLine);
                //7
                MessageBuilder2.Append("\t\u2022 Avoid vaccination");
                MessageBuilder2.Append(Environment.NewLine);

                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase  Nine

            if (comboSymptom.Text == "Sinus Swelling Under Turkey Eye")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Mycoplasmosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(CRD, Air Sac, Sinustis)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing high levels of spectrum antibiotics");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Using (Tylosin, aureomycin, terramycin, gallimycin)");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("either in feed, drinking water or by injections.");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 The upper form of infectious sinusitis can be ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("  treated with success by injecting antibiotics into ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  the swollen sinus cavity.");
                //6
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase Ten

          
            //Phase Eleven


            if (comboSymptom.Text == "Stupor")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Cholera");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 12 

            if (comboSymptom.Text == "Loss of Appetite")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Cholera ");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Fowl Typhoid");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 13
            if (comboSymptom.Text == "Rapid Weight Loss")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Cholera");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 14
            if (comboSymptom.Text == "Lameness")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Cholera");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }


            //Phase 15
            if (comboSymptom.Text == "Swollen Wattles")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Cholera");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 16
            if (comboSymptom.Text == "Difficult Breathing")
            {
                Labelfactor.Text = "Bacterial|Viral Disease";
                MessageBuilder.Append("Fowl Cholera ");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("New Castle");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 17
            if (comboSymptom.Text == "Watery, Yellowish or Green Diarrhea")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Cholera");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 18
            if (comboSymptom.Text == "Darkening of head & Wattles")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Cholera");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            // Phase 19

            if (comboSymptom.Text == "Listleness")
            {
                Labelfactor.Text = "Bacterial | Viral Disease";
                MessageBuilder.Append("Pullorum Disease");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Cecal Worm");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Avian Pox");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append(" The following drugs can be used");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 furazolidone");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 gentamycin sulfate");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 and sulfa drugs (sulfadimethoxine, sulfamethazine,");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append(" and sulfamerazine).");


                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 20

            if (comboSymptom.Text == "Increased Thirst and a Pale")
            {
                Labelfactor.Text = "Bacterial | Viral Disease";
                MessageBuilder.Append("Fowl Typhoid");
                MessageBuilder.Append(Environment.NewLine);
              
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append(" Thoroughly clean and disinfect the premises.");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 When feasible, practice range rotation ");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append(" and other special precautions to prevent the ");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append(" carryover of infection to the following flock.");
                
                //5


                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 21
            if (comboSymptom.Text == "Anemic Apperance of Comb & wattles")
            {
                Labelfactor.Text = "Bacterial | Viral Disease";
                MessageBuilder.Append("Fowl Typhoid");
                

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append(" Thoroughly clean and disinfect the premises.");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 When feasible, practice range rotation ");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append(" and other special precautions to prevent the ");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append(" carryover of infection to the following flock.");

                //5


                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 22

           

            //Phase 23

            if (comboSymptom.Text == "Weakness")
            {
                Labelfactor.Text = "Bacterial | Viral Disease";
                MessageBuilder.Append("Fowl Typhoid");
                MessageBuilder.Append(Environment.NewLine);

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Thoroughly clean and disinfect the premises.");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 When feasible, practice range rotation ");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append(" and other special precautions to prevent the ");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append(" carryover of infection to the following flock.");

                //5


                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 24
            if (comboSymptom.Text == "Noticeable Paralysis")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Fowl Typhoid");
                MessageBuilder.Append(Environment.NewLine);

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Locate and remove the source of the toxin");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Separate all visibly affected birds from the flock for treatment ");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                


                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 25
            if (comboSymptom.Text == "Egg Hatch Issues")
            {
                Labelfactor.Text = "Bacterial | Viral Disease";
                MessageBuilder.Append("Pullorum Disease");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Cecal Worm");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Avian Pox");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append(" The following drugs can be used");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 furazolidone");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 gentamycin sulfate");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 and sulfa drugs (sulfadimethoxine, sulfamethazine,");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append(" and sulfamerazine).");


                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 26

            if (comboSymptom.Text == "Slower / Retarded Growth")
            {
                Labelfactor.Text = "Bacterial|Viral Disease";
               
                MessageBuilder.Append("Newcastle Disease");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 27

            if (comboSymptom.Text == "Nervous Disorder")
            {
                Labelfactor.Text = "Bacterial|Viral Disease";

                MessageBuilder.Append("Newcastle Disease");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 28

            if (comboSymptom.Text == "Nasal Discharge")
            {
                Labelfactor.Text = "Bacterial Disease";
                MessageBuilder.Append("Mycoplasmosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(CRD, Air Sac, Sinustis)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Providing high levels of spectrum antibiotics");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("\t\u2022 Using (Tylosin, aureomycin, terramycin, gallimycin)");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("either in feed, drinking water or by injections.");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 The upper form of infectious sinusitis can be ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("  treated with success by injecting antibiotics into ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  the swollen sinus cavity.");
                //6
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            // Phase 29

            if (comboSymptom.Text == "Excessive Mucous in trachea")
            {
                Labelfactor.Text = "Bacterial|Viral Disease";

                MessageBuilder.Append("Newcastle Disease");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

          

            //Phase 31
            if (comboSymptom.Text == "Cloudiness in the cornea of the eye")
            {
                Labelfactor.Text = "Bacterial|Viral Disease";

                MessageBuilder.Append("Newcastle Disease");

                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            if (comboSymptom.Text == "Gasping & Sneezing")
            {
                Labelfactor.Text = "Bacterial|Viral Disease";

                MessageBuilder.Append("Newcastle Disease");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("Mycoplasmosis");
                MessageBuilder.Append(Environment.NewLine);
                MessageBuilder.Append("(CRD, Air Sac, Sinustis)");
                labelDisease.Text = MessageBuilder.ToString();
                //solution
                MessageBuilder2.Append("\t\u2022 Complete depopulation each year with definite breaks between ");
                MessageBuilder2.Append(Environment.NewLine);
                //2
                MessageBuilder2.Append("  older birds and their replacements,");
                MessageBuilder2.Append(Environment.NewLine);
                //3
                MessageBuilder2.Append("\t\u2022 Implement a rodent control program,");
                MessageBuilder2.Append(Environment.NewLine);
                //4
                MessageBuilder2.Append("\t\u2022 Dispose of dead birds properly, ");
                MessageBuilder2.Append(Environment.NewLine);
                //5
                MessageBuilder2.Append("\t\u2022 Provide safe, sanitary water, ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Clean and disinfect all houses and equipment");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("after disposing of flock,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Keep birds confined to the house and away from wild ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  feral birds and animals,");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("\t\u2022 Allow contaminated ranges or yards to remain ");
                MessageBuilder2.Append(Environment.NewLine);
                MessageBuilder2.Append("  vacant for at least three months.");

                //6 
                labelRecommendation.Text = MessageBuilder2.ToString();

            }

            //Phase 32


        }

        private void PoultryDoc_Load(object sender, EventArgs e)
        {
            comboSymptom.SelectedItem = "-- Select Noticed Symptom --";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
           
            if (progress == 30)
            {
                timer1.Stop();
                loader.Visible = false;
                panelResult.Visible = true;
            }
            
    
          
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboSymptom_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelResult.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
               
               
           
        }
    }
}
