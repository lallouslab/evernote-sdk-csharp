/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
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

namespace Evernote.EDAM.Type
{

  /// <summary>
  /// A structure that represents contact information. Note this does not necessarily correspond to
  /// an Evernote user.
  /// 
  /// <dl>
  /// <dt>name</dt>
  /// <dd>The displayable name of this contact. This field is filled in by the service and
  ///     is read-only to clients.
  /// </dd>
  /// <dt>id</dt>
  /// <dd>A unique identifier for this ContactType.
  /// </dd>
  /// <dt>type</dt>
  /// <dd>What service does this contact come from?
  /// </dd>
  /// <dt>photoUrl</dt>
  /// <dd>A URL of a profile photo representing this Contact. This field is filled in by the
  ///     service and is read-only to clients.
  /// </dd>
  /// <dt>photoLastUpdated</dt>
  /// <dd>timestamp when the profile photo at 'photoUrl' was last updated.
  ///     This field will be null if the user has never set a profile photo.
  ///     This field is filled in by the service and is read-only to clients.
  /// </dd>
  /// <dt>messagingPermit</dt>
  /// <dd>This field will only be filled by the service when it is giving a Contact record
  ///     to a client, and that client does not normally have enough permission to send a
  ///     new message to the person represented through this Contact. In that case, this
  ///     whole Contact record could be used to send a new Message to the Contact, and the
  ///     service will inspect this permit to confirm that operation was allowed.
  /// </dd>
  /// <dt>messagingPermitExpires</dt>
  /// <dd>If this field is set, then this (whole) Contact record may be used in calls to
  ///     sendMessage until this time. After that time, those calls may be rejected by the
  ///     service if the caller does not have direct permission to initiate a message with
  ///     the represented Evernote user.
  /// </dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Contact : TBase
  {
    private string _name;
    private string _id;
    private ContactType _type;
    private string _photoUrl;
    private long _photoLastUpdated;
    private byte[] _messagingPermit;
    private long _messagingPermitExpires;

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ContactType"/>
    /// </summary>
    public ContactType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public string PhotoUrl
    {
      get
      {
        return _photoUrl;
      }
      set
      {
        __isset.photoUrl = true;
        this._photoUrl = value;
      }
    }

    public long PhotoLastUpdated
    {
      get
      {
        return _photoLastUpdated;
      }
      set
      {
        __isset.photoLastUpdated = true;
        this._photoLastUpdated = value;
      }
    }

    public byte[] MessagingPermit
    {
      get
      {
        return _messagingPermit;
      }
      set
      {
        __isset.messagingPermit = true;
        this._messagingPermit = value;
      }
    }

    public long MessagingPermitExpires
    {
      get
      {
        return _messagingPermitExpires;
      }
      set
      {
        __isset.messagingPermitExpires = true;
        this._messagingPermitExpires = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool name;
      public bool id;
      public bool type;
      public bool photoUrl;
      public bool photoLastUpdated;
      public bool messagingPermit;
      public bool messagingPermitExpires;
    }

    public Contact() {
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
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Id = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                Type = (ContactType)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                PhotoUrl = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I64) {
                PhotoLastUpdated = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                MessagingPermit = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I64) {
                MessagingPermitExpires = iprot.ReadI64();
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
        TStruct struc = new TStruct("Contact");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Id != null && __isset.id) {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Id);
          oprot.WriteFieldEnd();
        }
        if (__isset.type) {
          field.Name = "type";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Type);
          oprot.WriteFieldEnd();
        }
        if (PhotoUrl != null && __isset.photoUrl) {
          field.Name = "photoUrl";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(PhotoUrl);
          oprot.WriteFieldEnd();
        }
        if (__isset.photoLastUpdated) {
          field.Name = "photoLastUpdated";
          field.Type = TType.I64;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(PhotoLastUpdated);
          oprot.WriteFieldEnd();
        }
        if (MessagingPermit != null && __isset.messagingPermit) {
          field.Name = "messagingPermit";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(MessagingPermit);
          oprot.WriteFieldEnd();
        }
        if (__isset.messagingPermitExpires) {
          field.Name = "messagingPermitExpires";
          field.Type = TType.I64;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(MessagingPermitExpires);
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
      StringBuilder __sb = new StringBuilder("Contact(");
      bool __first = true;
      if (Name != null && __isset.name) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Name: ");
        __sb.Append(Name);
      }
      if (Id != null && __isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (__isset.type) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Type: ");
        __sb.Append(Type);
      }
      if (PhotoUrl != null && __isset.photoUrl) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PhotoUrl: ");
        __sb.Append(PhotoUrl);
      }
      if (__isset.photoLastUpdated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PhotoLastUpdated: ");
        __sb.Append(PhotoLastUpdated);
      }
      if (MessagingPermit != null && __isset.messagingPermit) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MessagingPermit: ");
        __sb.Append(MessagingPermit);
      }
      if (__isset.messagingPermitExpires) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MessagingPermitExpires: ");
        __sb.Append(MessagingPermitExpires);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
