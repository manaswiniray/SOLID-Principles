namespace SOLIDPrinciples
{
    

// Interfaces for different parts of the car
public interface IMobileStand { }
    public interface ISteeringCover { }
    public interface ISeatCover { }
    public interface IDisplayUnit { }
    public interface ISubWoofer { }
    public interface IAutoCurtain { }
    public interface IMobileCharger { }
    public interface IGaneshaIdol { }
    public interface IVacuumCleaner { }

    // Interface for the final product (Car)
    public interface ICar
    {
        void Display();
    }

    // Concrete product (Car)
    public class Car : ICar
    {
        private IMobileStand mobileStand;
        private ISteeringCover steeringCover;
        private ISeatCover seatCover;
        private IDisplayUnit displayUnit;
        private ISubWoofer subWoofer;
        private IAutoCurtain autoCurtain;
        private IMobileCharger mobileCharger;
        private IGaneshaIdol ganeshaIdol;
        private IVacuumCleaner vacuumCleaner;

        public Car(IMobileStand mobileStand, ISteeringCover steeringCover, ISeatCover seatCover,
                   IDisplayUnit displayUnit, ISubWoofer subWoofer, IAutoCurtain autoCurtain,
                   IMobileCharger mobileCharger, IGaneshaIdol ganeshaIdol, IVacuumCleaner vacuumCleaner)
        {
            this.mobileStand = mobileStand;
            this.steeringCover = steeringCover;
            this.seatCover = seatCover;
            this.displayUnit = displayUnit;
            this.subWoofer = subWoofer;
            this.autoCurtain = autoCurtain;
            this.mobileCharger = mobileCharger;
            this.ganeshaIdol = ganeshaIdol;
            this.vacuumCleaner = vacuumCleaner;
        }

        public void Display()
        {
            Console.WriteLine("Car assembled with the following features:");
            Console.WriteLine("- Mobile Stand");
            Console.WriteLine("- Steering Cover");
            Console.WriteLine("- Seat Cover");
            Console.WriteLine("- Display Unit");
            Console.WriteLine("- SubWoofer");
            Console.WriteLine("- Auto Curtain");
            Console.WriteLine("- Mobile Charger");
            Console.WriteLine("- Ganesha Idol");
            Console.WriteLine("- Vacuum Cleaner");
        }
    }

    // Builder interface
    public interface IBuilder
    {
        void AddMobileStand();
        void AddSteeringCover();
        void AddSeatCover();
        void AddDisplayUnit();
        void AddSubWoofer();
        void AddAutoCurtain();
        void AddMobileCharger();
        void AddGaneshaIdol();
        void AddVacuumCleaner();
        ICar Build();
    }

    // Concrete builder
    public class VxiBuilder : IBuilder
    {
        private IMobileStand mobileStand;
        private ISteeringCover steeringCover;
        private ISeatCover seatCover;
        private IDisplayUnit displayUnit;
        private ISubWoofer subWoofer;
        private IAutoCurtain autoCurtain;
        private IMobileCharger mobileCharger;
        private IGaneshaIdol ganeshaIdol;
        private IVacuumCleaner vacuumCleaner;

        public void AddMobileStand() { mobileStand = new MobileStand(); }
        public void AddSteeringCover() { steeringCover = new SteeringCover(); }
        public void AddSeatCover() { seatCover = new SeatCover(); }
        public void AddDisplayUnit() { displayUnit = new DisplayUnit(); }
        public void AddSubWoofer() { subWoofer = new SubWoofer(); }
        public void AddAutoCurtain() { autoCurtain = new AutoCurtain(); }
        public void AddMobileCharger() { mobileCharger = new MobileCharger(); }
        public void AddGaneshaIdol() { ganeshaIdol = new GaneshaIdol(); }
        public void AddVacuumCleaner() { vacuumCleaner = new VacuumCleaner(); }

        public ICar Build()
        {
            return new Car(mobileStand, steeringCover, seatCover, displayUnit,
                           subWoofer, autoCurtain, mobileCharger, ganeshaIdol, vacuumCleaner);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBuilder vxiBuilder = new VxiBuilder();

            vxiBuilder.AddMobileStand();
            vxiBuilder.AddSteeringCover();
            vxiBuilder.AddSeatCover();
            vxiBuilder.AddDisplayUnit();
            vxiBuilder.AddSubWoofer();
            vxiBuilder.AddAutoCurtain();
            vxiBuilder.AddMobileCharger();
            vxiBuilder.AddGaneshaIdol();
            vxiBuilder.AddVacuumCleaner();

            ICar car = vxiBuilder.Build();
            car.Display();
        }
    }

}
