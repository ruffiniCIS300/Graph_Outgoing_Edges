/* Lab32Form.cs
 * Author: Nick Ruffini
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ksu.Cis300.Graphs;
using System.IO;

namespace Ksu.Cis300.MaximumOutgoingSum
{
    public partial class Lab32Form : Form
    {
        public Lab32Form()
        {
            InitializeComponent();
        }

        private void uxButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = uxOpenFileDialog.FileName;
                    DirectedGraph<string, decimal> graph = ReadGraph(filePath);
                    decimal maxSum = MaxSum(graph);
                    MessageBox.Show(maxSum.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /// <summary>
        /// Reads a graph in from a file!
        /// </summary>
        /// <param name="fileName"> Name of the file we are reading in </param>
        /// <returns> DirectedGraph containing the graph we just read in </returns>
        private DirectedGraph<string, decimal> ReadGraph(string fileName)
        {
            DirectedGraph<string, decimal> newGraph = new DirectedGraph<string, decimal>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                sr.ReadLine();
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] components = line.Split(new Char[] {','});
                    string sourceNode = components[0];
                    string destinationNode = components[1];
                    decimal weight = Convert.ToDecimal(components[2]);

                    newGraph.AddEdge(sourceNode, destinationNode, weight);
                }
            }
            return newGraph;
        }

        /// <summary>
        ///  Find the maximum sum of edge weights from any node in a graph
        /// </summary>
        /// <param name="graph"> Graph that we are traversing through </param>
        /// <returns> Decimal value of the max sum of a node's edges from our graph </returns>
        private decimal MaxSum(DirectedGraph<string, decimal> graph)
        {
            decimal max = 0;
            foreach (string node in graph.Nodes)
            {
                decimal thisNodeSum = 0;
                foreach(Edge<string, decimal> value in graph.OutgoingEdges(node))
                {
                    thisNodeSum += value.Data;
                }
                if (thisNodeSum > max)
                {
                    max = thisNodeSum;
                }
            }
            return max;
        }
    }
}
