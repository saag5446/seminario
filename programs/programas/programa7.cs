using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Program7
    {

        private String promedio;
        private double totalWeightKid, kids;
        private double totalWeightYouth, youths;
        private double totalWeightAdult, adults;
        private double totalWeightAged, aged;

        public double getKids() {
            return kids;
        }

        public void setKids(double kids) {
            this.kids = kids;
        }

        public double getYouths() {
            return youths;
        }

        public void setYouths(double youths) {
            this.youths = youths;
        }

        public double getAdults() {
            return adults;
        }

        public void setAdults(double adults) {
            this.adults = adults;
        }

        public double getAged() {
            return aged;
        }

        public void setAged(double aged) {
            this.aged = aged;
        }

        public double getTotalWeightKid() {
            return totalWeightKid;
        }

        public void setTotalWeightKid(double totalWeightKid) {
            this.totalWeightKid = totalWeightKid;
        }

        public double getTotalWeightYouth() {
            return totalWeightYouth;
        }

        public void setTotalWeightYouth(double totalWeightYouth) {
            this.totalWeightYouth = totalWeightYouth;
        }

        public double getTotalWeightAdult() {
            return totalWeightAdult;
        }

        public void setTotalWeightAdult(double totalWeightAdult) {
            this.totalWeightAdult = totalWeightAdult;
        }

        public double getTotalWeightAged() {
            return totalWeightAged;
        }

        public void setTotalWeightAged(double totalWeightAged) {
            this.totalWeightAged = totalWeightAged;
        }
        
        public void setPromedio(double[] pro){
            promedio = "Promedio:";
            promedio += "\nNiños: " + pro[0];
            promedio += "\nJovenes: " + pro[1];
            promedio += "\nAdultos: " + pro[2];
            promedio += "\nViejos: " + pro[3];
        }
        
        public String getPromedio(){
            return promedio;
        }

        public void addWeight(double weight, int age){
            if(age < 14){
                setTotalWeightKid(getTotalWeightKid() + weight);
                setKids(getKids() + 1);
            }
            else if(age < 31){
                setTotalWeightYouth(getTotalWeightYouth()+ weight);
                setYouths(getYouths() + 1);
            }
            else if(age < 60){
                setTotalWeightAdult(getTotalWeightAdult()+ weight);
                setAdults(getAdults() + 1);
            }
            else{
                setTotalWeightAged(getTotalWeightAged()+ weight);
                setAged(getAged() + 1);
            }
        }

        public void calcular(){
        
            double[] promedios = new double[4];
            promedios[0] = getTotalWeightKid()/ getKids();
            promedios[1] = getTotalWeightYouth()/ getYouths();
            promedios[2] = getTotalWeightAdult() / getAdults();
            promedios[3] = getTotalWeightAged()/ getAged();
            setPromedio(promedios);
            
        }
        public void fun() {
        
            Console.WriteLine("Digita la cantidad de personas:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Ingresa la edad:");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el peso:");
                double peso = double.Parse(Console.ReadLine());
                addWeight(peso, edad);
            }
            calcular();
            Console.WriteLine(getPromedio());
            
        }
    }
}