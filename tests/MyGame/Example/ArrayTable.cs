// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame.Example
{

using global::System;
using global::FlatBuffers;

public struct ArrayTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ArrayTable GetRootAsArrayTable(ByteBuffer _bb) { return GetRootAsArrayTable(_bb, new ArrayTable()); }
  public static ArrayTable GetRootAsArrayTable(ByteBuffer _bb, ArrayTable obj) { FlatBufferConstants.FLATBUFFERS_1_11_1(); return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool ArrayTableBufferHasIdentifier(ByteBuffer _bb) { return Table.__has_identifier(_bb, "ARRT"); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ArrayTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public MyGame.Example.ArrayStruct? A { get { int o = __p.__offset(4); return o != 0 ? (MyGame.Example.ArrayStruct?)(new MyGame.Example.ArrayStruct()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartArrayTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddA(FlatBufferBuilder builder, Offset<MyGame.Example.ArrayStruct> aOffset) { builder.AddStruct(0, aOffset.Value, 0); }
  public static Offset<MyGame.Example.ArrayTable> EndArrayTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<MyGame.Example.ArrayTable>(o);
  }
  public static void FinishArrayTableBuffer(FlatBufferBuilder builder, Offset<MyGame.Example.ArrayTable> offset) { builder.Finish(offset.Value, "ARRT"); }
  public static void FinishSizePrefixedArrayTableBuffer(FlatBufferBuilder builder, Offset<MyGame.Example.ArrayTable> offset) { builder.FinishSizePrefixed(offset.Value, "ARRT"); }
};


}
