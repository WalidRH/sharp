using GeoAPI.Geometries;
using SharpMap.Data;
using SharpMap.Data.Providers;
using SharpMap.Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Npgsql;

namespace projetantenne
{
    public partial class Form1 : Form
    {
        string cnx = "server=localhost;port=5432;database=project;username=postgres;pwd=root";
        PostGIS DataQuartier;
        PostGIS DataAntenne;
        VectorLayer LayerQuartier;
        VectorLayer Layerantenne;
        VectorLayer LayerSelection;
        public Form1()
        {
            InitializeComponent();
            DataQuartier = new PostGIS(cnx, "quartier", "id");
            DataAntenne = new PostGIS(cnx, "antenne", "code_a");
            LayerQuartier = new VectorLayer("qrt", DataQuartier);
            LayerQuartier.Style.Fill = Brushes.Green;
            LayerQuartier.Style.Outline = new Pen(Color.Black, 1);
            LayerQuartier.Style.EnableOutline = true;
            LayerSelection = new VectorLayer("selection");
            LayerSelection.Style.Fill = Brushes.Yellow;
            Layerantenne = new VectorLayer("ant", DataAntenne);
            MyMap.Map.Layers.Add(LayerQuartier);
            MyMap.Map.Layers.Add(Layerantenne);
            MyMap.Map.ZoomToExtents();
            MyMap.Refresh();
        }

         private void MyMap_MouseDown(GeoAPI.Geometries.Coordinate worldPos, MouseEventArgs imagePos)
        {
            //FeatureDataSet ds = new FeatureDataSet();//a dataset that exists only in a geodatabase workspace 
            //Envelope box = new Envelope(worldPos);// represent the bounding box of a Geometry, e.g. the minimum and maximum x and y values of the Coordinates
            //box.ExpandBy(0.001);
            //Layerantenne.ExecuteIntersectionQuery(box, ds);
            //FeatureDataRow row = ds.Tables[0][0];
            //lbl.Text = string.Format("{0} , {1}", row[0], row[1]);
            //// Console.WriteLine("X: {0} , Y: {1}", Cursor.Position.X, Cursor.Position.Y);
            // Console.WriteLine("{0} , {1}", row[0], row[1]);
            ////.OSGeo.OGR.DataSource = new GeometryProvider(row);
            ////MyMap.Map.Layers.Add( );


            //MyMap.Refresh();
            List<double> coordx = new List<double>();
            List<double> coordy = new List<double>();
            List<double> rayon = new List<double>();

            NpgsqlConnection conn = new NpgsqlConnection(cnx);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT ST_X(position), ST_Y(position), ST_AsText(position),rayon,code_a  FROM antenne", conn);

            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                coordx.Add((Convert.ToDouble(dr[0])));
                coordy.Add((Convert.ToDouble(dr[1])));
                rayon.Add((Convert.ToDouble(dr[3])));

            }
            conn.Close();

            X.Text = "x:" + worldPos.X.ToString();
            Y.Text = "y:" + worldPos.X.ToString();



            for (int i = 0; i < rayon.Count(); i++)
            {
               
                double dis = Math.Sqrt(Math.Pow((coordx[i] - worldPos.X), Convert.ToDouble(2)) + Math.Pow((coordy[i] - worldPos.Y), Convert.ToDouble(2)));
                if (dis < rayon[i])
                {
                    Console.Write("\n_______________________\n" + coordx[i] + "\t" + coordy[i] +"\trayon"+rayon[i]+ "\n");
                    label3.Text = "Vous êtes connecter à l'antenne d'identifiant" + i;
                    label2.Text = "Antenne de rayon de " + rayon[i];
                }


            }
        }
    }
}
