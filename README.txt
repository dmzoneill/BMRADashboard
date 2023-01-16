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

IMPORTANT - READ BEFORE COPYING, INSTALLING OR USING.
Do not copy, install, or use the Materials provided under this license agreement ("Agreement"), until you 
have carefully read the following terms and conditions.

By copying, installing, or otherwise using the Materials, you agree to be bound by the terms of this 
Agreement.  If you do not agree to the terms of this Agreement, do not copy, install, or use the Materials.

End User License Agreement for the Intel(R) Software Development Products

1.	LICENSE DEFINITIONS: 

A.	"Materials" are defined as the software, documentation, license key codes and other materials, 
including any updates and upgrade thereto, for the applicable Intel Software Development Product 
(which may be found at http://www.intel.com/software/products/), that are provided to you under this 
Agreement.  Materials also include the Redistributables as defined below.

B.	"Redistributables" are the files listed in the following text files that may be included in the Materials 
for the applicable Intel Software Development Product: clredist.txt, credist.txt, fredist.txt, redist.txt..

C.	 "Cluster OpenMP Library", is comprised of the files listed in the "clredist.txt" file specified above, is 
the Intel(R) Cluster OpenMP* Library add-on option to the Intel(R) C++ Compiler for Linux* and 
Intel(R) Fortran Compiler for Linux* products ("Intel Compiler for Linux").  The use of the Cluster 
OpenMP Library is conditioned on having a valid license from Intel for the Cluster OpenMP Library  
and for either Intel Compiler for Linux, and further is governed by the terms and conditions of the 
license agreement for applicable the Intel Compiler for Linux.

D.	"Source Code" is defined as the Materials provided in human readable format, whether unmodified 
or modified by you.  

E.	"Sample Source" is the Source Code file(s) that: (i) demonstrate certain limited functions included in 
the binary libraries of the Intel(R) Integrated Performance Primitives ("Intel(R) IPPs"); (ii) are 
identified as Intel IPP sample source code; and (iii) are obtained separately from Intel after you 
register your copy of the Intel Integrated Performance Primitives product with Intel.

F.	"Microsoft Platforms" means any current and future Microsoft operating system products, Microsoft 
run-time technologies (such as the .NET Framework), and Microsoft application platforms (such as 
Microsoft Office or Microsoft Dynamics) that Microsoft offers.

2.	LICENSE GRANT:

A.	Subject to all of the terms and conditions of this Agreement, Intel Corporation ("Intel") grants to you 
a non-exclusive, non-assignable, copyright license to use the Materials. 

B.	Subject to all of the terms and conditions of this Agreement, Intel grants to you a non-exclusive, 
non-assignable copyright license to modify the Materials, or any portions thereof, that are (i) 
provided in Source Code form or, (ii) are defined as Redistributables and are provided in text form.

C.	Subject to all of the terms and conditions of this Agreement and any specific restrictions which may 
appear in the Redistributables text files, Intel grants to you a non-exclusive, non-assignable, fully-
paid copyright license to distribute (except if you received the Materials under an Evaluation License 
as specified below) the Redistributables, or any portions thereof, as part of the product or 
application you developed using the Materials.  If such application is a software development library, 
then attribution, as specified in the product release notes of the corresponding Materials, shall be 
displayed prominently in that application's product documentation and on the application's product 
web site. 

3.	LICENSE RESTRICTIONS:

A.	If you receive your first copy of the Materials electronically, and a second copy on media, then you 
may use the second copy only in accordance with your applicable license stated in this Agreement, 
or for backup or archival purposes.  You may not provide the second copy to another user.

B.	You may NOT:  (i) use or copy the Materials except as provided in this Agreement; (ii) rent or lease 
the Materials to any third party; (iii) assign this Agreement or transfer the Materials without the 
express written consent of Intel; (iv) modify, adapt, or translate the Materials in whole or in part 
except as provided in this Agreement; (v) reverse engineer, decompile, or disassemble the 
Materials; (vi) attempt to modify or tamper with the normal function of a license manager that 
regulates usage of the Materials; (vii) distribute, sublicense or transfer the Source Code form of any 
components of the Materials, Redistributables and Sample Source and derivatives thereof to any 
third party except as provided in this Agreement; (viii) distribute Redistributables except as part of a 
larger program that adds significant primary functionality different from that of the Redistributables; 
(ix) distribute the Redistributables to run on a platform other than a Microsoft Platform if per the 
accompanying user documentation the Materials are meant to execute on the Microsoft Platforms; 
(x) modify or distribute the Source Code of any Redistributable so that any part of it becomes 
subject to an Excluded License.  An "Excluded License" is one that requires, as a condition of use, 
modification, or distribution, that (a) the code be disclosed or distributed in source code form; or (b) 
others have the right to modify it; or (xi) include the Redistributables in malicious, deceptive, or unlawful 
programs.

C.	The scope and duration (time period) of your license depends on the type of license you obtained 
from Intel.  The variety of license types are set forth below, which may not be available for all 
"Intel(R) Software Development Products" and therefore may not apply to the Materials.  For more 
information on the types of licenses, please contact Intel or your sales representative.

i.	EVALUATION LICENSE: If you are using the Materials under the control of an Evaluation 
license, you as an individual may use the Materials only for internal evaluation purposes and 
only for the term of the evaluation time period, which is controlled by the license key code for the 
Materials.  NOTWITHSTANDING ANYTHING TO THE CONTRARY ELSEWHERE IN THIS 
AGREEMENT, YOU MAY NOT DISTRIBUTE ANY PORTION OF THE MATERIALS, AND THE 
APPLICATION AND/OR PRODUCT DEVELOPED BY YOU MAY ONLY BE USED FOR 
EVALUATION PURPOSES AND ONLY FOR THE TERM OF THE EVALUATION PERIOD.  
You may install copies of the Materials on an unlimited number of computers provided that you 
are the only individual using the Materials and only one copy of the Materials is in use at any 
one time.  A separate license is required for each additional use and/or individual user in all 
other cases.  Intel will provide you with a license code key that enables the Materials for an 
Evaluation license.  If you are an entity, Intel grants you the right to designate one individual 
within your organization to have the sole right to use the Materials in the manner provided 
above.

ii.	NONCOMMERCIAL-USE LICENSE:  If you are using the Materials under the control of a 
Noncommercial-Use license, you as an individual may use the Materials only for non-business 
use where you receive no fee, salary or any other form of compensation.  The Materials may not 
be used for any other purpose, whether "for profit" or "not for profit."  Any work performed or 
produced as a result of use of the Materials cannot be performed or produced for the benefit of 
other parties for a fee, compensation or any other reimbursement or remuneration.  You may 
install copies of the Materials on an unlimited number of computers provided that you are the 
only individual using the Materials and only one copy of the Materials is in use at any one time.  
A separate license is required for each additional use and/or individual user in all other cases.  
Intel will provide you with a license code key that enables the Materials for a Noncommercial-
Use license.  If you obtained a time-limited Noncommercial-Use license, the duration (time 
period) of your license and your ability to use the Materials is limited to the time period of the 
obtained license, which is controlled by the license key code for the Materials.  If you are an 
entity, Intel grants you the right to designate one individual within your organization to have the 
sole right to use the Materials in the manner provided above.

iii.	SINGLE-USER LICENSE: If you are using the Materials under the control of a Single-User 
license, you as an individual may install and use the Materials on an unlimited number of 
computers provided that you are the only individual using the Materials and only one copy of the 
Materials is in use at any one time.  A separate license is required for each additional use and/or 
individual user in all other cases.  Intel will provide you with a license code key that enables the 
Materials for a Single-User license.  If you obtained a time-limited Single-User license, the 
duration (time period) of your license and your ability to use the Materials is limited to the time 
period of the obtained license, which is controlled by the license key code for the Materials.  If 
you are an entity, Intel grants you the right to designate one individual within your organization 
to have the sole right to use the Materials in the manner provided above.

iv.	NODE-LOCKED LICENSE: If you are using the Materials under the control of a Node-Locked 
license, you may use the Materials only on a single designated computer by no more than the 
authorized number of concurrent users.  A separate license is required for each additional 
concurrent user and/or computer in all other cases.  Intel will provide you with a license code 
key that enables the Materials for a Node-Locked license up to the authorized number of 
concurrent users.  If you obtained a time-limited Node-Locked license, the duration (time period) 
of your license and your ability to use the Materials is limited to the time period of the obtained 
license, which is controlled by the license key code for the Materials.

v.	FLOATING LICENSE: If you are using the Materials under the control of a Floating license, you 
may (a) install the Materials on an unlimited number of computers that are connected to the 
designated network and (b) use the Material by no more than the authorized number of 
concurrent users.  A separate license is required for each additional concurrent user and/or 
network on which the Materials are used.  Intel will provide you with a license code key that 
enables the Materials for a Floating license up to the authorized number of concurrent users.  If 
you obtained a time-limited Floating license, the duration (time period) of your license and your 
ability to use the Materials is limited to the time period of the obtained license, which is 
controlled by the license key code for the Materials.  Intel Library Floating License: If the 
Materials are the Intel(R) Math Kernel Library or the Intel(R) Integrated Performance Primitives 
Library or the Intel(R) Threading Building Blocks (either "Intel Library"), then the Intel Library is 
provided to you as an add-on option to either the Intel(R) C++ Compiler product or the Intel(R) 
Fortran Compiler product (either "Intel Compiler") for which you have a Floating license, and as 
such, in addition to the terms and conditions above, the Intel Library may only be used by the 
authorized concurrent users of that Intel Compiler Floating license.

D.	DISTRIBUTION:  Distribution of the Redistributables is also subject to the following limitations:  You 
(i) shall be solely responsible to your customers for any update or support obligation or other liability 
which may arise from the distribution, (ii) shall not make any statement that your product is 
"certified", or that its performance is guaranteed, by Intel, (iii) shall not use Intel's name or 
trademarks to market your product without written permission, (iv) shall use a license agreement 
that prohibits disassembly and reverse engineering of the Redistributables, (v) shall not publish 
reviews of Materials designated as beta without written permission by Intel, and (vi) shall indemnify, 
hold harmless, and defend Intel and its suppliers from and against any claims or lawsuits, including 
attorney's fees, that arise or result from your distribution of any product.

E.	Intel(R) Integrated Performance Primitives (Intel IPP). The following terms and conditions apply 
only to the Intel IPP.

i.	 Notwithstanding anything in this Agreement to the contrary, if you implement the Sample 
Sources in your application or if you use Intel IPP to implement algorithms that are protected by 
others' licenses then you may need additional licenses from various entities. Should any such 
additional licenses be required, you are solely responsible for obtaining any such licenses and 
agree to obtain any such licenses at your own expense.

ii.	Notwithstanding anything herein to the contrary, a valid license to Intel IPP is a prerequisite to 
any license for Sample Source, and possession of Sample Source does not grant any license to 
Intel IPP (or any portion thereof).  To access Sample Source, you must first register your 
licensed copy of the Intel IPP with Intel.  By downloading, installing or copying any Sample 
Source file, you agree to be bound by terms of this Agreement.

F.	SOFTWARE TRANSFER:  You may permanently transfer the Materials and all of your rights under 
this Agreement to another party ("Recipient") only if you notify Intel of the transfer by sending a letter 
to Intel certifying that you retain no copies of the Materials and that the Recipient has agreed in 
writing to be bound by all of the terms and conditions of this Agreement.  Please send such letter to:

Intel Corporation
2111 NE 25th Avenue
Hillsboro, OR 97124
Attn: DPD Contracts Management, JF1-15

4.	COPYRIGHT: Title to the Materials and all copies thereof remain with Intel or its suppliers.  The 
Materials are copyrighted and are protected by United States copyright laws and international treaty 
provisions.  You will not remove any copyright notice from the Materials.  You agree to prevent any 
unauthorized copying of the Materials.  Except as expressly provided herein, no license or right is 
granted to you directly or by implication, inducement, estoppel or otherwise, specifically Intel does not 
grant any express or implied right to you under Intel patents, copyrights, trademarks, or trade secret 
information.

5.	NO WARRANTY AND LIMITED REPLACEMENT:  THE MATERIALS AND INFORMATION ARE 
PROVIDED "AS IS" WITH NO WARRANTIES, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
LIMITED TO ANY IMPLIED WARRANTY OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE, NON-INFRINGEMENT OF INTELLECTUAL PROPERTY RIGHTS, OR ANY WARRANTY 
OTHERWISE ARISING OUT OF ANY PROPOSAL, SPECIFICATION, OR SAMPLE.  If the media on 
which the Materials are furnished are found to be defective in material or workmanship under normal 
use for a period of ninety (90) days from the date of receipt, Intel's entire liability and your exclusive 
remedy shall be the replacement of the media.  This offer is void if the media defect results from 
accident, abuse, or misapplication.

6.	LIMITATION OF LIABILITY: THE ABOVE REPLACEMENT PROVISION IS THE ONLY WARRANTY 
OF ANY KIND.  INTEL OFFERS NO OTHER WARRANTY EITHER EXPRESS OR IMPLIED 
INCLUDING THOSE OF MERCHANTABILITY, NONINFRINGEMENT OF THIRD- PARTY 
INTELLECTUAL PROPERTY OR FITNESS FOR A PARTICULAR PURPOSE. NEITHER INTEL NOR 
ITS SUPPLIERS SHALL BE LIABLE FOR ANY DAMAGES WHATSOEVER (INCLUDING, WITHOUT 
LIMITATION, DAMAGES FOR LOSS OF BUSINESS PROFITS, BUSINESS INTERRUPTION, LOSS 
OF BUSINESS INFORMATION, OR OTHER LOSS) ARISING OUT OF THE USE OF OR INABILITY 
TO USE THE SOFTWARE, EVEN IF INTEL HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH 
DAMAGES.  BECAUSE SOME JURISDICTIONS PROHIBIT THE EXCLUSION OR LIMITATION OF 
LIABILITY FOR CONSEQUENTIAL OR INCIDENTAL DAMAGES, THE ABOVE LIMITATION MAY NOT 
APPLY TO YOU.

7.	UNAUTHORIZED USE:  THE MATERIALS ARE NOT DESIGNED, INTENDED, OR AUTHORIZED 
FOR USE IN ANY TYPE OF SYSTEM OR APPLICATION IN WHICH THE FAILURE OF THE 
MATERIALS COULD CREATE A SITUATION WHERE PERSONAL INJURY OR DEATH MAY OCCUR 
(E.G MEDICAL SYSTEMS, LIFE SUSTAINING OR LIFE SAVING SYSTEMS).  Should the buyer 
purchase or use the Materials for any such unintended or unauthorized use, the buyer shall indemnify 
and hold Intel and its officers, subsidiaries and affiliates harmless against all claims, costs, damages, 
and expenses, and reasonable attorney fees arising out of, directly or indirectly, any claim of product 
liability, personal injury or death associated with such unintended or unauthorized use, even if such 
claim alleges that Intel was negligent regarding the design or manufacture of the part.

8.	USER SUBMISSIONS:  You agree that any material, information or other communication you transmit 
or post to an Intel website or provide to Intel under this Agreement related to the features, functions, 
performance or use of the Materials will be considered non-confidential and non-proprietary 
("Communications").  Intel will have no obligations with respect to the Communications.  You agree that 
Intel and its designees will be free to copy, modify, create derivative works, publicly display, disclose, 
distribute, license and sublicense through multiple tiers of distribution and licensees, incorporate and 
otherwise use the Communications and all data, images, sounds, text, and other things embodied 
therein, including derivative works thereto, for any and all commercial or non-commercial purposes. You 
are prohibited from posting or transmitting to or from an Intel website or provide to Intel any unlawful, 
threatening, libelous, defamatory, obscene, pornographic, or other material that would violate any law.  If 
you wish to provide Intel with your confidential information, Intel requires a non-disclosure agreement 
("NDA") to receive such confidential information, so please contact your Intel representative to ensure 
the proper NDA is in place.

9.	CONSENT.  You agree that Intel, its subsidiaries or suppliers may collect and use technical and related 
information, including but not limited to technical information about your computer, system and 
application software, and peripherals, that is gathered periodically to facilitate the provision of software 
updates, product support and other services to you (if any) related to the Materials, and to verify 
compliance with the terms of this Agreement.  Intel may use this information, as long as it is in a form 
that does not personally identify you, to improve our products or to provide services or technologies to 
you.

10.	TERMINATION OF THIS LICENSE: This Agreement becomes effective on the date you accept this 
Agreement and will continue until terminated as provided for in this Agreement.  If you are using the 
Materials under the control of a time-limited license, for example an Evaluation License, this Agreement 
terminates without notice on the last day of the time period, which is controlled by the license key code 
for the Materials.  Intel may terminate this license immediately if you are in breach of any of its terms 
and conditions and such breach is not cured within thirty (30) days of written notice from Intel.  Upon 
termination, you will immediately return to Intel or destroy the Materials and all copies thereof.  Any 
distribution of the Redistributables conducted in accordance with the terms and conditions of this 
Agreement shall survive termination of this Agreement.

11.	U.S. GOVERNMENT RESTRICTED RIGHTS: The Materials are provided with "RESTRICTED 
RIGHTS". Use, duplication or disclosure by the Government is subject to restrictions set forth in 
FAR52.227-14 and DFAR252.227-7013 et seq. or its successor.  Use of the Materials by the 
Government constitutes acknowledgment of Intel's rights in them.

12.	APPLICABLE LAWS: Any claim arising under or relating to this Agreement shall be governed by the 
internal substantive laws of the State of Delaware, without regard to principles of conflict of laws.  You 
agree that the terms of the United Nations Convention on Contracts for the Sale of Goods do not apply to this 
Agreement. You agree that your distribution and export/re-export of the Software and permitted modifications shall 
be in compliance with the laws, regulations, orders or other restrictions of applicable export laws.

13.	THIRD PARTY PROGRAMS.  The Materials may include third party programs or materials.  The license 
terms with those programs or materials apply to your use of them, and Intel is not liable for them.

* Other names and brands may be claimed as the property of others