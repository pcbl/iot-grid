# iot-grid
Demo Project targeting to use some interesting IOT related technologies

**Overview**

![uncached image](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/pcbl/iot-grid/master/diagrams/overview.plantuml)

**IOT-Server**

To run a demo server
```
docker run --name OPCServer -p 1010:50000 mcr.microsoft.com/iotedge/opc-plc --aa
```

**Some Tools and Information**

 - PlantUML Online Editor: https://plantuml-editor.kkeisuke.com/
 - OPC UA.Net Core SDK: https://github.com/OPCFoundation/UA-.NETStandard
   - Check the [NetCoreConsoleClient](https://github.com/OPCFoundation/UA-.NETStandard/tree/master/SampleApplications/Samples/NetCoreConsoleClient) for a lightweight sample
 - OPC UA Expert (Client) - https://uaexpert.software.informer.com/download/ , https://www.traeger.de/downloads/doc_download/105-opc-ua-watch
 - Grafana: https://grafana.com/
 - Prometheus: https://prometheus.io/
 - IOT Edge: Alternative to use instead of Collection Service: https://azure.microsoft.com/en-us/services/iot-edge/
 
**Steps**
1. Run the Docker Simulation
```
docker run --name OPCServer -p 1010:50000 mcr.microsoft.com/iotedge/opc-plc --aa
```
2. Connect to the Simulation using OPC UA CLient (https://uaexpert.software.informer.com/download/ or https://www.traeger.de/downloads/doc_download/105-opc-ua-watch)
3. Write a program that reads the data from a tag(StepUp for example). Check the [NetCoreConsoleClient](https://github.com/OPCFoundation/UA-.NETStandard/tree/master/SampleApplications/Samples/NetCoreConsoleClient)
4. Start a Prometherus Docker: https://docs.docker.com/config/daemon/prometheus/
5. Save Data to Prometheus instance
6. Start a Gafana Docker: https://hub.docker.com/r/grafana/grafana/
7. Create a Dashboard using the Prometheus as Datasource
8. Add an API Gateway between the Adapter and Prometheus Writer
9. Add an OAuth2 Authentication to make it safer
