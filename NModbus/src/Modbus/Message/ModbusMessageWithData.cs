using System;
using System.Collections.Generic;
using System.Text;
using Modbus.Data;

namespace Modbus.Message
{
	public abstract class ModbusMessageWithData<TData> : ModbusMessage, IModbusMessage
		where TData : IModbusMessageDataCollection
	{
		private TData _data;

		public ModbusMessageWithData()
		{
		}

		public ModbusMessageWithData(byte slaveAddress, byte functionCode)
			: base(slaveAddress, functionCode)
		{
		}

		public TData Data
		{
			get { return (TData) MessageImpl.Data; }
			set { MessageImpl.Data = value; }
		}
	}
}
