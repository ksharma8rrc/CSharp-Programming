namespace RRC.ADEV.csharp1
{

    public class StudentInfo
    {
        //step 1 :declaration
        int id;
        string firstname;
        string lastname;

        // step 2: Getting
        public void GetInfo(int xx, string yy, string zz)
        {
            this.id = xx;
            this.firstname = yy;
            this.lastname = zz;
        }

        // step3: using information

        public int GetID()
        {
            return id;
        }

        public string Return_Fname()
        {
            return firstname;
        }

        public  string Return_Lname()
        {  return lastname;
        }

    }

}
