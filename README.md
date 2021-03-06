# Analogy.LogViewer.Winforms [![Gitter](https://badges.gitter.im/Analogy-LogViewer/community.svg)](https://gitter.im/Analogy-LogViewer/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge) [![Build Status](https://dev.azure.com/Analogy-LogViewer/Analogy%20Log%20Viewer/_apis/build/status/Analogy-LogViewer.Analogy.LogViewer.Winforms?branchName=master)](https://dev.azure.com/Analogy-LogViewer/Analogy%20Log%20Viewer/_build/latest?definitionId=10&branchName=master)
**WIP - Not yet ready for use**

Basic winforms Implementation (no third parties UI libraries usage like DevExpress/Syncfusion)
The other versions are
1. DevExpress (V19.1.9) in the repo: https://github.com/Analogy-LogViewer/Analogy.LogViewer
2. SyncFusion in the repo: https://github.com/Analogy-LogViewer/Analogy.LogViewer.Syncfusion

current status:
- [X] Convert Data Grid Control for messages
- [X] Covert all User Controls (Ribbons, ToolStrips, Windows Forms etc)
- [X] Remove any reference to DevExpress assemblies
- [ ] Fix small related UI bugs post conversion to Winforms version

Analogy Log Viewer is multi purpose Log Viewer for Windows Operating systems (with built-in NLog Parser and others).

The application has many standard operations for analysis logs (like filtering, excluding) but its strength is in the ability to add additional custom data sources by implementing few interfaces.
This allows adding any logs formats and/or custom modification of logs before presenting the data in the UI Layer.
Some features of this tool are:
1.	Windows event log support (evtx files)
2.	Logs aggregation into single view.
3.	Search in multiple files
4.	Combine multiple files
5.	Compare logs 
6.	Themes support
7.	64 bit support (allow loading more files compare to old tool)
8.	Personalization (users settings per user) 
9.	Columns extension to add more columns specific to the data source implementation
10.	Exporting to Excel/CSV files

Main interaction UI:
- Ribbon area: Log files operations (open) and tools (search/combine/Compare)
- Messages area: File system UI and Main Log viewer area
![Main screen](Assets/AnalogyMainUI.jpg)

# Dependencies & Build
- Main Application UI is complied to .Net Framework 4.7.2 and to .Net Core 3.0.
The projects targets .Net Framework 4.7.2/Core 3.0 .
After successfull build any custom data source assemblies should be placed at the same folder as the executable (Analogy.exe) with the folowing pattern Analogy.LogViewer.*.dll
- Analogy Interfaces assembly is complied in .Net Standard 2.0.

Detailed Documentation will be added to the Wiki page.

# Data Providers

List of data providers exist at the overview repository: https://github.com/Analogy-LogViewer/Overview

# Usage

The primary usage of this application is to implement your own data source of logs of your own business domain by implementing small Interface but there are built in data providers (like NLog parser) that can be used without and additional coding.

<a name="contact"></a>
## Contact

### Owner
- [Lior Banai](mailto:liorbanai@gmail.com)

