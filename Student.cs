using System;

namespace hello{
    class Student{
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa){
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors(){
            if(gpa>=5.0){
                return true;
            }else{
                return false;
            }
        }
    }
}