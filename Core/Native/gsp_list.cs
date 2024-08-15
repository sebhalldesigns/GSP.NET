using System.Runtime.InteropServices;

namespace GSP.NET.Core.Native;

public struct glist_t {
    public UIntPtr raw;
}

public struct gnode_t {
    public UIntPtr raw;
}

public static class gsp_list {

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern glist_t gsp_list_create_list();

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void gsp_list_destroy_list(glist_t list);

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern gnode_t gsp_list_create_node(glist_t list);

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void gsp_list_destroy_node(glist_t list, gnode_t node);

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool gsp_list_does_list_exist(glist_t list);

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool gsp_list_does_node_exist(glist_t list, gnode_t node);
    
    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern UIntPtr gsp_list_get_node_count(glist_t list);

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern UIntPtr gsp_list_get_node_data(glist_t list, gnode_t node);

    [DllImport("GSPCore.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void gsp_list_set_node_data(glist_t list, gnode_t node, UIntPtr data);

}

