namespace InheritanceTask.Models
{
    public class PolyMorphism
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        //here r.h.s of method name (i.e Add) changed.So it is POLYMORPHISM
        public int Add(int x, int y,int z)
        {
            return x + y+ z;
        }
        //here l.h.s of method name (i.e Add) changed .but it do not come under POLYMORPHISM.So it is showing error
        //public float Add(int x, int y)
        //{
        //    return x + y;
        //}
        //here both l.h.s and r.h.s of method name changed.It also comes under POLYMORPHISM.
        public float Add(float x, float y)
        {
            return x + y;
        }

        
    }
}
