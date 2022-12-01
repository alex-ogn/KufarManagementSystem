using System.ComponentModel;

[Flags]
public enum ApplicatiinUserRoles
{
    [Description("Admin")]
    AdminRole,

    [Description("Client")]
    ClientRole,

    [Description("HotelManager")]
    HotelManagerRole,

    [Description("HotelEmployee")]
    HotelEmployeeRole,
}