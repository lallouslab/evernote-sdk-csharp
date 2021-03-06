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

namespace Evernote.EDAM.NoteStore
{

  /// <summary>
  /// This structure is provided to the findNotesMetadata function to specify
  /// the subset of fields that should be included in each NoteMetadata element
  /// that is returned in the NotesMetadataList.
  /// Each field on this structure is a boolean flag that indicates whether the
  /// corresponding field should be included in the NoteMetadata structure when
  /// it is returned.  For example, if the 'includeTitle' field is set on this
  /// structure when calling findNotesMetadata, then each NoteMetadata in the
  /// list should have its 'title' field set.
  /// If one of the fields in this spec is not set, then it will be treated as
  /// 'false' by the server, so the default behavior is to include nothing in
  /// replies (but the mandatory GUID)
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class NotesMetadataResultSpec : TBase
  {
    private bool _includeTitle;
    private bool _includeContentLength;
    private bool _includeCreated;
    private bool _includeUpdated;
    private bool _includeDeleted;
    private bool _includeUpdateSequenceNum;
    private bool _includeNotebookGuid;
    private bool _includeTagGuids;
    private bool _includeAttributes;
    private bool _includeLargestResourceMime;
    private bool _includeLargestResourceSize;

    public bool IncludeTitle
    {
      get
      {
        return _includeTitle;
      }
      set
      {
        __isset.includeTitle = true;
        this._includeTitle = value;
      }
    }

    public bool IncludeContentLength
    {
      get
      {
        return _includeContentLength;
      }
      set
      {
        __isset.includeContentLength = true;
        this._includeContentLength = value;
      }
    }

    public bool IncludeCreated
    {
      get
      {
        return _includeCreated;
      }
      set
      {
        __isset.includeCreated = true;
        this._includeCreated = value;
      }
    }

    public bool IncludeUpdated
    {
      get
      {
        return _includeUpdated;
      }
      set
      {
        __isset.includeUpdated = true;
        this._includeUpdated = value;
      }
    }

    public bool IncludeDeleted
    {
      get
      {
        return _includeDeleted;
      }
      set
      {
        __isset.includeDeleted = true;
        this._includeDeleted = value;
      }
    }

    public bool IncludeUpdateSequenceNum
    {
      get
      {
        return _includeUpdateSequenceNum;
      }
      set
      {
        __isset.includeUpdateSequenceNum = true;
        this._includeUpdateSequenceNum = value;
      }
    }

    public bool IncludeNotebookGuid
    {
      get
      {
        return _includeNotebookGuid;
      }
      set
      {
        __isset.includeNotebookGuid = true;
        this._includeNotebookGuid = value;
      }
    }

    public bool IncludeTagGuids
    {
      get
      {
        return _includeTagGuids;
      }
      set
      {
        __isset.includeTagGuids = true;
        this._includeTagGuids = value;
      }
    }

    public bool IncludeAttributes
    {
      get
      {
        return _includeAttributes;
      }
      set
      {
        __isset.includeAttributes = true;
        this._includeAttributes = value;
      }
    }

    public bool IncludeLargestResourceMime
    {
      get
      {
        return _includeLargestResourceMime;
      }
      set
      {
        __isset.includeLargestResourceMime = true;
        this._includeLargestResourceMime = value;
      }
    }

    public bool IncludeLargestResourceSize
    {
      get
      {
        return _includeLargestResourceSize;
      }
      set
      {
        __isset.includeLargestResourceSize = true;
        this._includeLargestResourceSize = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool includeTitle;
      public bool includeContentLength;
      public bool includeCreated;
      public bool includeUpdated;
      public bool includeDeleted;
      public bool includeUpdateSequenceNum;
      public bool includeNotebookGuid;
      public bool includeTagGuids;
      public bool includeAttributes;
      public bool includeLargestResourceMime;
      public bool includeLargestResourceSize;
    }

    public NotesMetadataResultSpec() {
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
            case 2:
              if (field.Type == TType.Bool) {
                IncludeTitle = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Bool) {
                IncludeContentLength = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Bool) {
                IncludeCreated = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Bool) {
                IncludeUpdated = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Bool) {
                IncludeDeleted = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.Bool) {
                IncludeUpdateSequenceNum = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.Bool) {
                IncludeNotebookGuid = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.Bool) {
                IncludeTagGuids = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 14:
              if (field.Type == TType.Bool) {
                IncludeAttributes = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 20:
              if (field.Type == TType.Bool) {
                IncludeLargestResourceMime = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 21:
              if (field.Type == TType.Bool) {
                IncludeLargestResourceSize = iprot.ReadBool();
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
        TStruct struc = new TStruct("NotesMetadataResultSpec");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.includeTitle) {
          field.Name = "includeTitle";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeTitle);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeContentLength) {
          field.Name = "includeContentLength";
          field.Type = TType.Bool;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeContentLength);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeCreated) {
          field.Name = "includeCreated";
          field.Type = TType.Bool;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeCreated);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeUpdated) {
          field.Name = "includeUpdated";
          field.Type = TType.Bool;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeUpdated);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeDeleted) {
          field.Name = "includeDeleted";
          field.Type = TType.Bool;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeDeleted);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeUpdateSequenceNum) {
          field.Name = "includeUpdateSequenceNum";
          field.Type = TType.Bool;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeUpdateSequenceNum);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeNotebookGuid) {
          field.Name = "includeNotebookGuid";
          field.Type = TType.Bool;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeNotebookGuid);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeTagGuids) {
          field.Name = "includeTagGuids";
          field.Type = TType.Bool;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeTagGuids);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeAttributes) {
          field.Name = "includeAttributes";
          field.Type = TType.Bool;
          field.ID = 14;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeAttributes);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeLargestResourceMime) {
          field.Name = "includeLargestResourceMime";
          field.Type = TType.Bool;
          field.ID = 20;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeLargestResourceMime);
          oprot.WriteFieldEnd();
        }
        if (__isset.includeLargestResourceSize) {
          field.Name = "includeLargestResourceSize";
          field.Type = TType.Bool;
          field.ID = 21;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IncludeLargestResourceSize);
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
      StringBuilder __sb = new StringBuilder("NotesMetadataResultSpec(");
      bool __first = true;
      if (__isset.includeTitle) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeTitle: ");
        __sb.Append(IncludeTitle);
      }
      if (__isset.includeContentLength) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeContentLength: ");
        __sb.Append(IncludeContentLength);
      }
      if (__isset.includeCreated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeCreated: ");
        __sb.Append(IncludeCreated);
      }
      if (__isset.includeUpdated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeUpdated: ");
        __sb.Append(IncludeUpdated);
      }
      if (__isset.includeDeleted) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeDeleted: ");
        __sb.Append(IncludeDeleted);
      }
      if (__isset.includeUpdateSequenceNum) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeUpdateSequenceNum: ");
        __sb.Append(IncludeUpdateSequenceNum);
      }
      if (__isset.includeNotebookGuid) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeNotebookGuid: ");
        __sb.Append(IncludeNotebookGuid);
      }
      if (__isset.includeTagGuids) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeTagGuids: ");
        __sb.Append(IncludeTagGuids);
      }
      if (__isset.includeAttributes) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeAttributes: ");
        __sb.Append(IncludeAttributes);
      }
      if (__isset.includeLargestResourceMime) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeLargestResourceMime: ");
        __sb.Append(IncludeLargestResourceMime);
      }
      if (__isset.includeLargestResourceSize) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IncludeLargestResourceSize: ");
        __sb.Append(IncludeLargestResourceSize);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
