/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Worldpay.Within.Rpc.Types
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Device : TBase
  {

    public string Uid { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Dictionary<int, Service> Services { get; set; }

    public string Ipv4Address { get; set; }

    public string CurrencyCode { get; set; }

    public Device() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Uid = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Description = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Map) {
                {
                  Services = new Dictionary<int, Service>();
                  TMap _map5 = iprot.ReadMapBegin();
                  for( int _i6 = 0; _i6 < _map5.Count; ++_i6)
                  {
                    int _key7;
                    Service _val8;
                    _key7 = iprot.ReadI32();
                    _val8 = new Service();
                    _val8.Read(iprot);
                    Services[_key7] = _val8;
                  }
                  iprot.ReadMapEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Ipv4Address = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                CurrencyCode = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("Device");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Uid != null) {
          field.Name = "uid";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Uid);
          oprot.WriteFieldEnd();
        }
        if (Name != null) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Description != null) {
          field.Name = "description";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Description);
          oprot.WriteFieldEnd();
        }
        if (Services != null) {
          field.Name = "services";
          field.Type = TType.Map;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteMapBegin(new TMap(TType.I32, TType.Struct, Services.Count));
            foreach (int _iter9 in Services.Keys)
            {
              oprot.WriteI32(_iter9);
              Services[_iter9].Write(oprot);
            }
            oprot.WriteMapEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Ipv4Address != null) {
          field.Name = "ipv4Address";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Ipv4Address);
          oprot.WriteFieldEnd();
        }
        if (CurrencyCode != null) {
          field.Name = "currencyCode";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CurrencyCode);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Device(");
      bool __first = true;
      if (Uid != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Uid: ");
        __sb.Append(Uid);
      }
      if (Name != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (Description != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Description: ");
        __sb.Append(Description);
      }
      if (Services != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Services: ");
        __sb.Append(Services);
      }
      if (Ipv4Address != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ipv4Address: ");
        __sb.Append(Ipv4Address);
      }
      if (CurrencyCode != null) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CurrencyCode: ");
        __sb.Append(CurrencyCode);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
