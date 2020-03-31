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
 - OPC UA Expert (Client) - https://uaexpert.software.informer.com/download/
 - Grafana: https://grafana.com/
 - Prometheus: https://prometheus.io/
 
 
  
