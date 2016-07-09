
//http://www.nws.noaa.gov/om/marine/gtlakes.htm
var locations = [{
    text: 'Great Lakes',
    selectable:false,
    nodes:
    [
        {
            text: 'Lake Erie',
            selectable:false,
            nodes:
            [{
                text: 'Offshore',
                selectable:false,
                nodes:
                [
                    { text: 'Lake Erie', 'url': '/great_lakes/LE/LEZ161.txt' },
                    { text: 'Detroit River Light to Maumee Bay OH to Reno Beach OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ162.txt' },
                    { text: 'Reno Beach to The Islands OH beyond 5 NM offshore to U.S./Canadian border ', 'url': '/great_lakes/LE/LEZ163.txt' },
                    { text: 'The Islands to Vermilion OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ164.txt' },
                    { text: 'Vermilion to Avon Point OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ165.txt' },
                    { text: 'Avon Point to Willowick OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ166.txt' },
                    { text: 'Willowick to Geneva-on-the Lake OH beyond 5 NM offshore to U.S./Canadian border (', 'url': '/great_lakes/LE/LEZ167.txt' },
                    { text: 'Geneva-on-the-Lake to Conneaut OH beyond 5 NM offshore to U.S./Canadian border ', 'url': '/great_lakes/LE/LEZ168.txt' },
                    { text: 'Conneaut OH to Ripley NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ169.txt' },
                    { text: 'Ripley to Buffalo NY extending from 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ061.txt' }
                ]
            },
            {
                text: 'Michigan Near Shore',
                selectable:false,
                nodes:
                [
                    { text: 'Michigan Waters of Lake Erie from Detroit River to North Cape, MI', 'url': '/near_shore/LE/LEZ444.txt' }
                ]
            },
            {
                text: 'Ohio Near Shore',
                selectable:false,
                nodes:
                [
                    { text: 'Maumee Bay to Reno Beach, OH', 'url': '/near_shore/LE/LEZ142.txt' },
                    { text: 'Reno Beach to The Islands, OH', 'url': '/near_shore/LE/LEZ143.txt' },
                    { text: 'The Islands to Vermilion, OH', 'url': '/near_shore/LE/LEZ144.txt' },
                    { text: 'Vermilion to Avon Point, OH', 'url': '/near_shore/LE/LEZ145.txt' },
                    { text: 'Avon Point to Willowick, OH', 'url': '/near_shore/LE/LEZ146.txt' },
                    { text: 'Willowick to Geneva-on-the-Lake, OH', 'url': '/near_shore/LE/LEZ147.txt' },
                    { text: 'Geneva-on-the-Lake to Conneaut, OH', 'url': '/near_shore/LE/LEZ148.txt' }
                ]
            },
            {
                text: 'Pennsylvania Near Shore',
                selectable:false,
                nodes:
                [
                    { text: 'Conneaut, OH to Ripley, NY', 'url': '/near_shore/LE/LEZ149.txt' },
                ]
            },
            {
                text: 'New York Near Shore',
                selectable:false,
                nodes:
                [
                    { text: 'Ripley to Dunkirk, NY', 'url': '/near_shore/LE/LEZ040.txt' },
                    { text: 'Dunkirk to Buffalo, NY', 'url': '/near_shore/LE/LEZ041.txt' },
                    { text: 'Upper Niagara River and Buffalo Harbor', 'url': '/near_shore/LE/LEZ020.txt' },
                    { text: 'Lower Niagara River', 'url': '/near_shore/LE/LEZ030.txt' },
                ]
            }

            ]
        },
          {
              text: 'Lake Huron',
              selectable:false,
nodes:
              [{
                  text: 'Lake Huron Offshore',
                  selectable:false,
nodes:
                  [
                      { text: 'Lake Huron MAFOR', 'url': '/great_lakes/LH/LHZ461.txt' },
                      { text: 'Lake Huron from 5 NM east of Mackinac Bridge to Presque Isle Light MI to the U.S./Canadian border 5 NM offshore', 'url': '/great_lakes/LH/LHZ361.txt' },
                      { text: 'Lake Huron from Presque Isle Light to Sturgeon Point MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LH/LHZ362.txt' },
                      { text: 'Lake Huron from Sturgeon Point to Alabaster MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LH/LHZ363.txt' },
                      { text: 'Lake Huron Port Austin to Harbor Beach MI 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LH/LHZ462.txt' },
                      { text: 'Lake Huron Harbor Beach to Port Sanilac MI 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LH/LHZ463.txt' },
                      { text: 'Lake Huron Port Sanilac to Port Huron 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LH/LHZ464.txt' }
                  ]
              },
              {
                  text: 'Michigan Shore Line',
                  selectable:false,
nodes:
                  [
                      { text: 'Straits of Mackinac within 5 NM of Mackinac Bridge including Mackinac Island', 'url': '/near_shore/LH/LHZ345.txt' },
                      { text: 'St. Ignace to False Detour Channel', 'url': '/near_shore/LH/LHZ346.txt' },
                      { text: '5 NM east of Mackinac Bridge to Presque Isle Light MI including Bois Blanc Island', 'url': '/near_shore/LH/LHZ347.txt' },
                      { text: 'Presque Isle Light to Sturgeon Point MI including Thunder Bay National Marine Sanctuary', 'url': '/near_shore/LH/LHZ348.txt' },
                      { text: 'Sturgeon Point to Alabaster MI', 'url': '/near_shore/LH/LHZ349.txt' },
                      { text: 'Port Austin to Harbor Beach, MI', 'url': '/near_shore/LH/LHZ441.txt' },
                      { text: 'Harbor Beach to Port Sanilac, MI', 'url': '/near_shore/LH/LHZ442.txt' },
                      { text: 'Port Sanilac to Port Huron, MI', 'url': '/near_shore/LH/LHZ443.txt' },
                      { text: 'Outer Saginaw Bay SW of Alabaster to Point Austin to Inner Saginaw Bay, MI', 'url': '/near_shore/LH/LHZ421.txt' },
                      { text: 'Inner Saginaw Bay...SW of Pt. Au Gres to Bay Port, MI', 'url': '/near_shore/LH/LHZ422.txt' }
                  ]
              }
              ]
          },
        {
              text: 'Lake Michigan',
              selectable:false,
nodes:
              [{
                  text: 'Lake Michigan Offshore',
                  selectable:false,
nodes:
                  [
                      { text: 'Lake Michigan MAFOR only(LMZ761.txt' },
                      { text: 'Lake Michigan from Seul Choix Point to Rock Island Passage 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ261.txt' },
                      { text: 'Lake Michigan south of a line from Seul Choix Point to the Mackinac Bridge and north of a line from Charlevoix MI to South Fox Island 5 NM offshore', 'url': '/great_lakes/LM/LMZ362.txt' },
                      { text: 'Lake Michigan from Charlevoix to Point Betsie MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ364.txt'},
                      { text: 'Lake Michigan from Point Betsie to Manistee MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ366.txt' },
                      { text: 'Lake Michigan from Rock Island Passage to Sturgeon Bay WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ563.txt' },
                      { text: 'Lake Michigan from Sturgeon Bay to Two Rivers WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ565.txt' },
                      { text: 'Lake Michigan from Two Rivers to Sheboygan WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ567.txt' },
                      { text: 'Lake Michigan from Sheboygan to Port Washington WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ669.txt' },
                      { text: 'Lake Michigan from Port Washington to North Point Light WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ671.txt' },
                      { text: 'Lake Michigan from North Point Light to Wind Point WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ673.txt' },
                      { text: 'Lake Michigan from Wind Point WI to Winthrop Harbor IL 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ675.txt' },
                      { text: 'Lake Michigan from Winthrop Harbor to Wilmette Harbor IL 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ777.txt' },
                      { text: 'Lake Michigan from Wilmette Harbor IL to Michigan City IN 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ779.txt' },
                      { text: 'Lake Michigan from Michigan City IN to St. Joseph MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ080.txt' },
                      { text: 'Lake Michigan from St. Joseph to South Haven MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ878.txt' },
                      { text: 'Lake Michigan from South Haven to Holland MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ876.txt' },
                      { text: 'Lake Michigan from Holland to Grand Haven MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ874.txt' },
                      { text: 'Lake Michigan from Grand Haven to Whitehall MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ872.txt' },
                      { text: 'Lake Michigan from Whitehall to Pentwater MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ870.txt' },
                      { text: 'Lake Michigan from Pentwater to Manistee MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ868.txt' }
                  ]
              },
              {
                  text: 'Michigan Shore Line',
                  selectable:false,
nodes:
                  [
                      { text: 'Green Bay north of a line from Cedar River MI to Rock Island Passage', 'url': '/near_shore/LM/LMZ221.txt' },
                      { text: 'Seul Choix Point to Point Detour MI', 'url': '/near_shore/LM/LMZ248.txt' },
                      { text: '5 NM east of a line from Fairport MI to Rock Island Passage', 'url': '/near_shore/LM/LMZ250.txt' },
                      { text: 'Seul Choix Point to 5 NM west of Mackinac Bridge', 'url': '/near_shore/LM/LMZ341.txt' },
                      { text: 'Norwood MI to 5 NM west of Mackinac Bridge including Little Traverse Bay', 'url': '/near_shore/LM/LMZ342.txt' },
                      { text: 'Grand Traverse Bay south of a line Grand Traverse Light to Norwood MI', 'url': '/near_shore/LM/LMZ323.txt' },
                      { text: 'Sleeping Bear Point to Grand Traverse Light MI', 'url': '/near_shore/LM/LMZ344.txt' },
                      { text: 'Point Betsie to Sleeping Bear Point MI', 'url': '/near_shore/LM/LMZ345.txt' },
                      { text: 'Manistee to Point Betsie MI', 'url': '/near_shore/LM/LMZ346.txt' },
                      { text: 'Pentwater to Manistee, MI', 'url': '/near_shore/LM/LMZ849.txt' },
                      { text: 'Whitehall to Pentwater, MI', 'url': '/near_shore/LM/LMZ848.txt' },
                      { text: 'Grand Haven to Whitehall, MI', 'url': '/near_shore/LM/LMZ847.txt' },
                      { text: 'Holland to Grand Haven, MI', 'url': '/near_shore/LM/LMZ846.txt' },
                      { text: 'South Haven to Holland, MI', 'url': '/near_shore/LM/LMZ845.txt' },
                      { text: 'St. Joseph to South Haven, MI', 'url': '/near_shore/LM/LMZ844.txt' },
                      { text: 'New Buffalo MI to St. Joseph, MI', 'url': '/near_shore/LM/LMZ043.txt' },
                      { text: 'Michigan City, IN to New Buffalo, MI', 'url': '/near_shore/LM/LMZ046.txt' },
                  ]},
        {
        text: 'Wisconsin Shore Line',
        selectable:false,
nodes:
        [
            { text: 'Green Bay south of line from Cedar River MI to Rock Island Passage and north of a line from Oconto WI to Little Sturgeon Bay WI', 'url': '/near_shore/LM/LMZ521.txt' },
            { text: 'Green Bay south of a line from Oconto WI to Little Sturgeon Bay WI', 'url': '/near_shore/LM/LMZ522.txt' },
            { text: 'Rock Island Passage to Sturgeon Bay WI', 'url': '/near_shore/LM/LMZ541.txt' },
            { text: 'Sturgeon Bay to Two Rivers WI', 'url': '/near_shore/LM/LMZ542.txt' },
                      { text: 'wo Rivers to Sheboygan WI', 'url': '/near_shore/LM/LMZ543.txt' },
                        { text: 'Sheboygan to Port Washington, WI', 'url': '/near_shore/LM/LMZ643.txt' },
                        { text: 'Port Washington to North Point Light, WI', 'url': '/near_shore/LM/LMZ644.txt' },
                        { text: 'North Point Light to Wind Point, WI', 'url': '/near_shore/LM/LMZ645.txt' },
                        { text: 'Wind Point to Winthrop Harbor, IL', 'url': '/near_shore/LM/LMZ646.txt' },
                  ]},
    {
        text: 'Illinois Shore Line',
        selectable:false,
nodes:
        [
            { text: 'Winthrop Harbor to Wilmette Harbor, IL', 'url': '/near_shore/LM/LMZ740.txt' },
            { text: 'Wilmette Harbor to Northerly Island, IL', 'url': '/near_shore/LM/LMZ741.txt' },
            { text: 'Northerly Island to Calumet Harbor, IL', 'url': '/near_shore/LM/LMZ742.txt' },
        ]},
          {
              text: 'Indiana Shore Line',
              selectable:false,
nodes:
              [
                  { text: 'Calumet Harbor to Gary, IN', 'url': '/near_shore/LM/LMZ743.txt' },
                  { text: 'Gary to Burns Harbor, IN', 'url': '/near_shore/LM/LMZ744.txt' },
                  { text: 'Burns Harbor to Michigan City, IN', 'url': '/near_shore/LM/LMZ745.txt' },
                  { text: 'Michigan City, IN to New Buffalo, MI', 'url': '/near_shore/LM/LMZ046.txt' },
                  ]}
                ]
             },
        {
            text: 'Lake Ontario',
            selectable:false,
nodes:
            [{
                text: 'Lake Ontario Offshore',
                selectable:false,
nodes:
                [
                    { text: 'Lake Ontario', 'url': '/great_lakes/LO/LOZ061.txt' },
                    { text: 'Niagara River to Hamlin Beach NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ062.txt' },
                    { text: 'Hamlin Beach to Sodus Bay NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ063.txt' },
                    { text: 'Sodus Bay to Mexico Bay NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ064.txt' },
                    { text: 'Mexico Bay NY to the St. Lawrence River beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ065.txt' }
                ]
            },
             {
                 text: 'New York Shore Line',
                 selectable:false,
nodes:
 [
                     { text: 'Niagara River to Hamlin Beach, NY', 'url': '/near_shore/LO/LOZ042.txt' },
                     { text: 'Hamlin Beach to Sodus Bay, NY', 'url': '/near_shore/LO/LOZ043.txt' },
                     { text: 'Sodus Bay to Mexico Bay, NY', 'url': '/near_shore/LO/LOZ044.txt' },
                     { text: 'Mexico Bay, NY to the St. Lawrence River', 'url': '/near_shore/LO/LOZ045.txt' },
                     { text: 'St. Lawrence River above Ogdensburg, NY', 'url': '/great_lakes/SL/SLZ022.txt' },
                     { text: 'St. Lawrence River from Ogdensburg to St. Regis, NY', 'url': '/great_lakes/SL/SLZ024.txt' },
 ]
             }
            ]
        },
          {
              text: 'Lake St. Clair',
              selectable:false,
nodes:
              [{
                  text: 'Lake St. Clair Offshore (U.S. Portion)',
                  selectable:false,
nodes:
                  [
                      { text: 'Lake St. Clair (U.S. Portion)', 'url': '/great_lakes/LC/LCZ460.txt' }
                  ]
              },
               {
                   text: 'Lake St. Clair Near Shore',
                   selectable:false,
nodes:
                   [
                        { text: 'St. Clair River', 'url': '/great_lakes/LC/LCZ422.txt' },
                        { text: 'Lake St. Clair, MI (U.S. Portion)', 'url': '/great_lakes/LC/LCZ460.txt' },
                        { text: 'Detroit River', 'url': '/great_lakes/LC/LCZ423.txt' }
                   ]
               }
              ]
          },
        {
            text: 'Lake Superior',
            selectable:false,
nodes:
            [{
                text: 'Offshore',
                selectable:false,
nodes:
                [                   
                    { text: 'Lake Superior MAFOR only', 'url': '/great_lakes/LS/LSZ261.txt' },
                    { text: 'Lake Superior west of a line from Saxon Harbor WI to Grand Portage MN beyond 5 NM', 'url': '/great_lakes/LS/LSZ162.txt' },
                    { text: 'Lake Superior from Saxon Harbor WI to Upper Entrance to Portage Canal MI 5 NM offshore to the U.S./Canadian border including Isle Royal National Park', 'url': '/great_lakes/LS/LSZ263.txt' },
                    { text: 'Lake Superior from Upper Entrance to Portage Canal to Manitou Island MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LS/LSZ264.txt' },
                    { text: 'Lake Superior east of a line from Manitou Island to Marquette MI and west of a line from Grand Marais MI to the U.S./Canadian border beyond 5 NM from shore', 'url': '/great_lakes/LS/LSZ265.txt' },
                    { text: 'Lake Superior from Grand Marais MI to Whitefish Point MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LS/LSZ266.txt' },
                    { text: 'Lake Superior from Grand Marais MI to Whitefish Point MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LS/LSZ267.txt' }
               ]
            },
            {
                text: 'Minnesota Shore Line',
                selectable:false,
nodes:
                [
                                { text: 'Grand Portage to Grand Marais, MN', 'url': '/near_shore/LS/LSZ140.txt' },
                                { text: 'Grand Marais to Taconite Harbor, MN', 'url': '/near_shore/LS/LSZ141.txt' },
                                { text: 'Taconite Harbor to Silver Bay Harbor, MN', 'url': '/near_shore/LS/LSZ142.txt' },
                                { text: 'Silver Bay Harbor to Two Harbors, MN', 'url': '/near_shore/LS/LSZ143.txt' },
                                { text: 'Two Harbors to Duluth, MN', 'url': '/near_shore/LS/LSZ144.txt' },
                ]
            },
            {
                text: 'Wisconsin Shore Line',
                selectable:false,
            nodes:
	            [
                                { text: 'Duluth, MN to Port Wing, WI', 'url': '/near_shore/LS/LSZ145.txt' },
                                { text: 'Port Wing to Sand Island, WI', 'url': '/near_shore/LS/LSZ146.txt' },
                                { text: 'Sand Island to Bayfield, WI', 'url': '/near_shore/LS/LSZ147.txt' },
                                { text: 'Chequamegon Bay-Bayfield to Oak Point, WI', 'url': '/near_shore/LS/LSZ121.txt' },
                                { text: 'Oak Point to Saxon Harbor, WI', 'url': '/near_shore/LS/LSZ148.txt' }
	            ]
            },
            {
                text: 'Michigan Shore Line',
                selectable:false,
                nodes:
	            [
                                { text: 'Saxon Harbor WI to Black River MI', 'url': '/near_shore/LS/LSZ240.txt' },
                                { text: 'Black River to Ontonagon MI', 'url': '/near_shore/LS/LSZ241.txt' },
                                { text: 'Ontonagon to Upper Entrance of Portage Canal MI', 'url': '/near_shore/LS/LSZ242.txt' },
                                { text: 'Upper Entrance of Portage Canal to Eagle River MI', 'url': '/near_shore/LS/LSZ243.txt' },
                                { text: 'Eagle River to Manitou Island MI', 'url': '/near_shore/LS/LSZ244.txt' },
                                { text: 'Manitou Island to Point Isabelle MI', 'url': '/near_shore/LS/LSZ245.txt' },
                                { text: 'Point Isabelle to Lower Entrance of Portage Canal MI', 'url': '/near_shore/LS/LSZ246.txt' },
                                { text: 'Lower Entrance of Portage Canal to Huron Islands MI including Keweenaw and Huron Bays', 'url': '/near_shore/LS/LSZ247.txt' },
                                { text: 'Huron Islands to Marquette MI', 'url': '/near_shore/LS/LSZ248.txt' },
                                { text: 'Marquette to Munising MI', 'url': '/near_shore/LS/LSZ249.txt' },
                                { text: 'Munising to Grand Marais MI', 'url': '/near_shore/LS/LSZ250.txt' },
                                { text: 'Grand Marais to Whitefish Point MI', 'url': '/near_shore/LS/LSZ251.txt' },
                                { text: 'Whitefish Bay (U.S. Portion) Whitefish Point to Point Iroquois MI', 'url': '/near_shore/LS/LSZ321.txt' },
                                { text: 'St. Marys River Point Iroquois to E. Potagannissing Bay to Eastern Potagannissing Bay', 'url': '/near_shore/LS/LSZ322.txt' },
	            ]
            }
            ]
        }
    ]
}]

