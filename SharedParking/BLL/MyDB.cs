using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedParking.BLL
{
    enum FormState { Add, Update }
    public static class MyDB
    {
        public static AreaTable areas = new AreaTable();
        public static CustomersTable customers = new CustomersTable();
        public static OrderStatusTable ordersStatus = new OrderStatusTable();
        public static ParkingTable parking = new ParkingTable();
        public static ParkingAvailabilityTable parkingAvailability = new ParkingAvailabilityTable();
        public static ParkingOrdersTable parkingOrders = new ParkingOrdersTable();
        public static ParkingOwnersTable parkingOwners = new ParkingOwnersTable();
        public static ParkingSizeTable parkingSize = new ParkingSizeTable();
        public static PaymentsTable payments = new PaymentsTable();
        public static PermanentAvailabilityTable permanentAvailability = new PermanentAvailabilityTable();
        public static StaticOrdersTable staticOrders = new StaticOrdersTable();
        public static StreetsTable streets = new StreetsTable();
    }
}
