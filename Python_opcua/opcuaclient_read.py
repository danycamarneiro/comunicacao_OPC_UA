#!/usr/bin python
import json
from opcua import Client


# ======================================================================================================

# -----------------------------------   MAIN FUNCTION  -------------------------------------------------

# ======================================================================================================

def main():

    print("\n\nStarting\n")

    # ---------------------- OPC UA CLIENT INITIALIZATION -----------------------------

    url = "opc.tcp://ibhlinkua_011088:48010"  # IP Address of IBH Link UA (endpoint url)
    client = Client(url)

    # print("Client Connected to IBH Link UA ")

    # --------------------- OPC UA SERVER Nodes to read ---------------------------------

    names = ['temp', 'cpu_load', 'memory_load']
    ns = [6, 6, 6]
    i = [6005, 6017, 6019]

    # ------------------- Loop to continuously read nodes ---------------------------
    while True:
        msg_dictionary = {}
        client.connect()  # connect opc ua client to opc ua server

        for k in range(len(ns)):  # 'for' cycle to continuously read and process each node

            opcua_node = client.get_node("ns=" + str(ns[k]) + ";i=" + str(i[k]))  # define node to read
            opcua_data = opcua_node.get_value()  # read node

            # add entry to dictionary with format {"name" : "current_value"}
            # example: {"temp":"40.0"}
            msg_dictionary[names[k]] = '"' + str(opcua_data) + '"'

        msg_json = json.dumps(msg_dictionary)  # convert dictionary to json
        print(msg_json)

        # client.close_session()
        client.disconnect()

if __name__ == '__main__':
    main()


# useful links
# https://github.com/node-opcua/node-opcua/blob/master/documentation/creating_a_client_typescript.md