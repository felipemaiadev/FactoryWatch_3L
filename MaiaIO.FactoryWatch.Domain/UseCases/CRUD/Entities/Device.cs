using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Entities
{
    public class Device
    {
        public DeviceType device { get; set; }
        public DeviceVendors vendor { get; set; }
        public string codeId { get; set; }
        public DateTime installStamp { get; set; }



    }


    public enum DeviceType
    {
        [Display(Name = "PLC", Description = "Programmer Logic Controller")]
        plc = 0x001,
        [Display(Name = "HMI", Description = "Human Machine Interface")]
        ihm = 0x021,
        [Display(Name = "SCADA", Description = "Sistem Control and Data Aquisition")]
        scada = 0x022,
        [Display(Name = "ACDrive", Description = "Driver AC")]
        acDrive = 0x031,
        [Display(Name = "DCDrive", Description = "Driver DC")]
        dcDrive = 0x032,
        [Display(Name = "ServoDrive", Description = "Servo Driver")]
        servoDrive = 0x033,
        [Display(Name = "ACMotor", Description = "AC Motor")]
        acMotor = 0x041,
        [Display(Name = "DCMotor", Description = "DC Motor")]
        dcMotor = 0x042,
        [Display(Name = "ServoMotor", Description = "Servo Motor")]
        servoMotor = 0x043
    }

    public enum DeviceVendors
    {
        [Display(Name = "Siemens", Description = "Siemens Automation")]
        siemens = 0x101,
        [Display(Name = "Rockwell", Description = "Rockewell Automation")]
        rockwell = 0x102,
        [Display(Name = "Schneider", Description = "Schneider Eletric")]
        schineider = 0x103,
        [Display(Name = "WEG", Description = "Weg Automacao")]
        web = 0x104,
        [Display(Name = "ABB", Description = "")]
        abb = 0x105
    }
}

