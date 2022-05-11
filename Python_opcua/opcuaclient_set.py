#!/usr/bin python

from opcua import Client, ua

# ======================================================================================================

# -----------------------------------   MAIN FUNCTION  -------------------------------------------------

# ======================================================================================================

def main():

    print("\n\nStarting\n")

    # ---------------------- OPC UA CLIENT INITIALIZATION -----------------------------

    url = "opc.tcp://ibhlinkua_011088:48010"  # IP Address of IBH Link UA (endpoint url)

    node = input("Node id? [no quotation marks (PT: sem aspas)]\n")
    print("Selected node: " + node + "\n")
    client = Client(url)  #

    client.connect()  # connect opc ua client to opc ua server
    print("Client Connected to IBH Link UA \n\n")

    # --------------------- Choose state to write ---------------------------------
    #

    state_selected = False
    state = False
    press = input("Set True or False? [Type t or f]\n\n")

    while not state_selected:

        if press == 't' or press == 'T':
            state = True
            state_selected = True
        elif press == 'f' or press == 'F':
            state = False
            state_selected = True
        else:
            state_selected = False
            press = input('Invalid! Type t or f.\n')

    # --------------------- OPC UA SERVER Nodes write ---------------------------------

    opcua_node = client.get_node(node)  # define node to read

    print("\nPublishing " + str(state) + " to node: " + node)

    # Some opc ua servers (such as IBH Link UA) don't support normal python datatypes
    # 'state' is a normal python data type (boolean in this case)
    # For that reason "opcua_node.set_value(state)" does not work
    # There is a need to create a DataValue, so opcua_node_dv was created
    # Check link at the end
    opcua_node_dv = ua.DataValue(ua.Variant(state, ua.VariantType.Boolean))

    opcua_node.set_value(opcua_node_dv)

    # client.close_session()
    client.disconnect()


if __name__ == '__main__':
    main()


# useful links
# https://github.com/FreeOpcUa/python-opcua/issues/997