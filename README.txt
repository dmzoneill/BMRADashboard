/*
 * ##############################################################################
 * #                                                                            #
 * #  ** Welcome to the Container Bare Metal Experience Kit Dashboard v1.0 **   #
 * #                                                                            #
 * ##############################################################################
 */

** USER INSTALLATION NOTES **
Please note the following points when installing the Container Bare Metal Experience Kit Dashboard:
1. During install of the BM-RA-Dashboard-Setup.exe file, you will be asked to accept a License Agreement, please see 
   end of this readme if you wish to review conditions offline prior to launching .exe file.
2. The .exe install will create an app (which can be found in the startmenu) on your machine named 
   'Bare Metal Release Architecture Dashboard'. The .exe install will allow the user select where on their location 
   filesystem the app gets installed. Please note you can adjust the location during install.


** DESCRIPTION **
Thank you for using the Container Bare Metal Experience Kit Dashboard.

This README explains how to install and navigate the Container Bare Metal Experience Kit Dashboard.

This Container Bare Metal Experience Kit Dashboard is:
1.	A tool for communicating the value of recently introduced open-source container networking technologies, as 
    captures by the Container Bare Metal Experience Kits.
2.	A simple application that you can run on your laptop! No need for remote connectivity as all the information 
    is captured in the tool. Use it when engaging with partners.

The Container Bare Metal Experience Kit Dashboard provides a one-stop-shop for you to tell and show the value of the 
container networking technologies. It consists of 2 areas:
1.	Information Area:
	- Provides a detailed overview, in a “PPT like” format, of Container technology principles and of the open-sourced 
	  Containers networking features.
	- All these new features are explained in details in the Container Bare Metal Experience Kits which are a set 
	  collateral aiming to enable the technology adoption
	- Container Bare Metal Experience Kits are available on Intel Network Builders 
	  @ https://networkbuilders.intel.com/network-technologies/container-experience-kits
2.	Demo Area:
	- Provides demonstration of the value achieved when activating the newly introduced Containers networking features.
	- The data used by the demos was recorded in lab environment and is re-played when a demo is activated. For this 
	  reason, all demonstration represent actual results and the demo is “almost a real-time demo”.

The dashboard addresses the following key categories:
1.	Enhanced Platform Awareness(EPA): EPA support in Kubernetes now available (Node Feature Discovery mechanism, CPU 
    Pinning and Isolation, SR-IOV, Huge Pages).
2.	Kubernetes Multi-Networking: Kubernetes support for multi network interfaces (e.g. MULTUS) as required for NFV use
    cases.
3.	Cable Use Case: Developments done to enable optimal implementation of a Container bare-metal architecture in a 
    Virtual CMTS implementation
4.	Telemetry: Telemetry collection to ensure platform metrics and events are accessible through industry standard 
    interfaces.

** INSTALLATION **
Double-click the BMRA-Dashboard-Setup.exe file to start the install. Review the License Agreement as prompted and tick
the radio-button 'I accept the agreement' to proceed. Click 'Next'. Browse to the location where you wish to install
the dashboard files (the readme file will also be placed at this location). Click 'Next'. Tick the checkbox 'Create a
desktop shortcut'. Click 'Next'. Click 'Install'. After the install completes (~ 2 minutes), leave the checkbox 
'Launch Bare Metal Release Architecture Dashboard' ticked and click 'Finish'. This will launch the dashboard.
The installer will prompt you about your java installation, if it does not detect 64bit java.  You may have 32bit java 
installed, in which case the dashboard will not run.  Please go to the java website and download the 64bit installer.
https://java.com/en/download/manual.jsp

** RUNNING THE DASHBOARD **
To launch the Dashboard run/double-click on 'Bare Metal Release Architecture Dashboard' file (available from the desktop
or install folder). This will launch the data player called Oscar and the Dashboard GUI.

** NOTE: Only one instance of the GUI and Oscar for the Dashboard can run at a time. To restart the Dashboard shutdown 
both the GUI and Oscar before launching the Dashboard again. **

** NAVIGATION OF THE DASHBOARD **
There are two control panels on the left side of the screen: INFORMATION AREA and DEMO AREA. Use the INFORMATION AREA 
control panel on the upper left side of the screen to select a topic that you want to find out more about. This will 
take you to a sub-menu for that topic where you can choose what information you want displayed in the main display 
panel to the right. The INFORMATION AREA is not necessarily intended to be gone through in a specific order, although 
it can be, it was designed to allow you to focus on the information that is relevant to your discussion. Unlike a 
traditional PowerPoint presentation, the Dashboard is designed to facilitate an interactive discussion where some 
topics or information may not be used at all and other information may be visited several times. Before using the 
Dashboard in a presentation spend some time learning what information is available in each section and the 
navigation in each section.

The DEMO AREA control panel allows you to select from four technology demos. To display a demo select one of the four 
technologies listed in the DEMO AREA control panel. This will change the DEMO AREA control panel and provide the options 
specific to each demo. Select a packet size or start demo to play the demo selected. The left side of the main panel, 
the one in orange displays the data from a server that does not use the specific technology and the right side, the 
green one, shows the data from the server using the technology. The blue section in the middle shows the key take away 
and key performance indicator (KPI) comparison in the chart below. Click on the 'STOP TRAFFIC' to stop the flow of demo 
traffic, this will also stop the data playback. To resume playback select a packet size or start demo. More details 
about each demo can be found in the INFORMATION AREA for each of the specific technologies.

** REMOVAL, REINSTALLATION OR UPDATES **
To remove the Dashboard from your system, Click 'Uninstall' on the 'Bare Metal Release Architecture Dashboard' within 
your machine 'Apps & Features' (available via search for 'Add or remove programs' within Windows 10). If you need to 
reinstall the Dashboard, follow the install instructions above to run the BMRA-Dashboard-Setup.exe again. If an update 
to the Dashboard is released please see the README for the update for the steps to perform the update.

** CHANGE LOG **
v1.0 - Initial Release

** SUPPORT **
For customer support on Container Bare Metal Experience Kit content, please contact your local Regional Intel Field 
Application Engineer (FAE), FAE will redirect the query within Intel dependent on query type.

Trademarks
----------
Copyright © 2018 Intel Corporation. All rights reserved. Intel and the Intel logo are trademarks of Intel Corporation 
in the U.S. and/or other countries.
* Other names and brands may be claimed as the property of others.


** .exe License Agreement text **

The installer shows the Intel Software Development Products license stored in
Installer/eula.txt. Read that file to review the agreement before you run
BMRA-Dashboard-Setup.exe.
