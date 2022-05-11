#!/usr/bin python

from opcua import Client # import necessary package


# ======================================================================================================

# -----------------------------------   MAIN FUNCTION  -------------------------------------------------

# ======================================================================================================

def main():

    print("\n\nStarting\n")

    # ---------------------- OPC UA CLIENT INITIALIZATION -----------------------------

    url = "opc.tcp://ibhlinkua_011088:48010"  # IP Address of IBH Link UA (endpoint url)
    client = Client(url)  # create client

    node_ID = "ns=6;i=6005"

    # ------------------- Loop to continuously read nodes ---------------------------
    while True:

        client.connect()  # connect opc ua client to opc ua server

        temp_node = client.get_node(node_ID)  # define node to read

        temp_value = temp_node.get_value()  # read node

        print("\nCurrent OPC UA server temperature is " + str(temp_value))

        # client.close_session()
        client.disconnect()

if __name__ == '__main__':
    main()


# useful links
# https://github.com/node-opcua/node-opcua/blob/master/documentation/creating_a_client_typescript.md
# https://python-opcua.readthedocs.io/en/latest/client.html