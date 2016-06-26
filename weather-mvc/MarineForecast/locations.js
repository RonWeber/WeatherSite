
//http://www.nws.noaa.gov/om/marine/gtlakes.htm
var locations = [{
    'title': 'Great Lakes',
    'zones':
    [
        {
            'title': 'Lake Erie',
            'subZones':
            [{
                'title': 'Offshore',
                'forecasts':
                [
                    { 'Description': 'Lake Erie', 'url': '/great_lakes/LE/LEZ161.txt' },
                    { 'Description': 'Detroit River Light to Maumee Bay OH to Reno Beach OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ162.txt' },
                    { 'Description': 'Reno Beach to The Islands OH beyond 5 NM offshore to U.S./Canadian border ', 'url': '/great_lakes/LE/LEZ163.txt' },
                    { 'Description': 'The Islands to Vermilion OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ164.txt' },
                    { 'Description': 'Vermilion to Avon Point OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ165.txt' },
                    { 'Description': 'Avon Point to Willowick OH beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ166.txt' },
                    { 'Description': 'Willowick to Geneva-on-the Lake OH beyond 5 NM offshore to U.S./Canadian border (', 'url': '/great_lakes/LE/LEZ167.txt' },
                    { 'Description': 'Geneva-on-the-Lake to Conneaut OH beyond 5 NM offshore to U.S./Canadian border ', 'url': '/great_lakes/LE/LEZ168.txt' },
                    { 'Description': 'Conneaut OH to Ripley NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ169.txt' },
                    { 'Description': 'Ripley to Buffalo NY extending from 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LE/LEZ061.txt' }
                ]
            },
            {
                'title': 'Michigan Near Shore',
                'forecasts':
                [
                    { 'Description': 'Michigan Waters of Lake Erie from Detroit River to North Cape, MI', 'url': '/near_shore/LE/LEZ444.txt' }
                ]
            },
            {
                'title': 'Ohio Near Shore',
                'forecasts':
                [
                    { 'Description': 'Maumee Bay to Reno Beach, OH', 'url': '/near_shore/LE/LEZ142.txt' },
                    { 'Description': 'Reno Beach to The Islands, OH', 'url': '/near_shore/LE/LEZ143.txt' },
                    { 'Description': 'The Islands to Vermilion, OH', 'url': '/near_shore/LE/LEZ144.txt' },
                    { 'Description': 'Vermilion to Avon Point, OH', 'url': '/near_shore/LE/LEZ145.txt' },
                    { 'Description': 'Avon Point to Willowick, OH', 'url': '/near_shore/LE/LEZ146.txt' },
                    { 'Description': 'Willowick to Geneva-on-the-Lake, OH', 'url': '/near_shore/LE/LEZ147.txt' },
                    { 'Description': 'Geneva-on-the-Lake to Conneaut, OH', 'url': '/near_shore/LE/LEZ148.txt' }
                ]
            },
            {
                'title': 'Pennsylvania Near Shore',
                'forecasts':
                [
                    { 'Description': 'Conneaut, OH to Ripley, NY', 'url': '/near_shore/LE/LEZ149.txt' },
                ]
            },
            {
                'title': 'New York Near Shore',
                'forecasts':
                [
                    { 'Description': 'Ripley to Dunkirk, NY', 'url': '/near_shore/LE/LEZ040.txt' },
                    { 'Description': 'Dunkirk to Buffalo, NY', 'url': '/near_shore/LE/LEZ041.txt' },
                    { 'Description': 'Upper Niagara River and Buffalo Harbor', 'url': '/near_shore/LE/LEZ020.txt' },
                    { 'Description': 'Lower Niagara River', 'url': '/near_shore/LE/LEZ030.txt' },
                ]
            }

            ]
        },
          {
              'title': 'Lake Huron',
              'subZones':
              [{
                  'title': 'Lake Huron Offshore',
                  'forecasts':
                  [
                      { 'Description': 'Lake Huron MAFOR', 'url': '/great_lakes/LH/LHZ461.txt' },
                      { 'Description': 'Lake Huron from 5 NM east of Mackinac Bridge to Presque Isle Light MI to the U.S./Canadian border 5 NM offshore', 'url': '/great_lakes/LH/LHZ361.txt' },
                      { 'Description': 'Lake Huron from Presque Isle Light to Sturgeon Point MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LH/LHZ362.txt' },
                      { 'Description': 'Lake Huron from Sturgeon Point to Alabaster MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LH/LHZ363.txt' },
                      { 'Description': 'Lake Huron Port Austin to Harbor Beach MI 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LH/LHZ462.txt' },
                      { 'Description': 'Lake Huron Harbor Beach to Port Sanilac MI 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LH/LHZ463.txt' },
                      { 'Description': 'Lake Huron Port Sanilac to Port Huron 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LH/LHZ464.txt' }
                  ]
              },
              {
                  'title': 'Michigan Shore Line',
                  'forecasts':
                  [
                      { 'Description': 'Straits of Mackinac within 5 NM of Mackinac Bridge including Mackinac Island', 'url': '/near_shore/LH/LHZ345.txt' },
                      { 'Description': 'St. Ignace to False Detour Channel', 'url': '/near_shore/LH/LHZ346.txt' },
                      { 'Description': '5 NM east of Mackinac Bridge to Presque Isle Light MI including Bois Blanc Island', 'url': '/near_shore/LH/LHZ347.txt' },
                      { 'Description': 'Presque Isle Light to Sturgeon Point MI including Thunder Bay National Marine Sanctuary', 'url': '/near_shore/LH/LHZ348.txt' },
                      { 'Description': 'Sturgeon Point to Alabaster MI', 'url': '/near_shore/LH/LHZ349.txt' },
                      { 'Description': 'Port Austin to Harbor Beach, MI', 'url': '/near_shore/LH/LHZ441.txt' },
                      { 'Description': 'Harbor Beach to Port Sanilac, MI', 'url': '/near_shore/LH/LHZ442.txt' },
                      { 'Description': 'Port Sanilac to Port Huron, MI', 'url': '/near_shore/LH/LHZ443.txt' },
                      { 'Description': 'Outer Saginaw Bay SW of Alabaster to Point Austin to Inner Saginaw Bay, MI', 'url': '/near_shore/LH/LHZ421.txt' },
                      { 'Description': 'Inner Saginaw Bay...SW of Pt. Au Gres to Bay Port, MI', 'url': '/near_shore/LH/LHZ422.txt' }
                  ]
              }
              ]
          },
        {
              'title': 'Lake Michigan',
              'subZones':
              [{
                  'title': 'Lake Michigan Offshore',
                  'forecasts':
                  [
                      { 'Description': 'Lake Michigan MAFOR only(LMZ761.txt' },
                      { 'Description': 'Lake Michigan from Seul Choix Point to Rock Island Passage 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ261.txt' },
                      { 'Description': 'Lake Michigan south of a line from Seul Choix Point to the Mackinac Bridge and north of a line from Charlevoix MI to South Fox Island 5 NM offshore', 'url': '/great_lakes/LM/LMZ362.txt' },
                      { 'Description': 'Lake Michigan from Charlevoix to Point Betsie MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ364.txt'},
                      { 'Description': 'Lake Michigan from Point Betsie to Manistee MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ366.txt' },
                      { 'Description': 'Lake Michigan from Rock Island Passage to Sturgeon Bay WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ563.txt' },
                      { 'Description': 'Lake Michigan from Sturgeon Bay to Two Rivers WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ565.txt' },
                      { 'Description': 'Lake Michigan from Two Rivers to Sheboygan WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ567.txt' },
                      { 'Description': 'Lake Michigan from Sheboygan to Port Washington WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ669.txt' },
                      { 'Description': 'Lake Michigan from Port Washington to North Point Light WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ671.txt' },
                      { 'Description': 'Lake Michigan from North Point Light to Wind Point WI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ673.txt' },
                      { 'Description': 'Lake Michigan from Wind Point WI to Winthrop Harbor IL 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ675.txt' },
                      { 'Description': 'Lake Michigan from Winthrop Harbor to Wilmette Harbor IL 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ777.txt' },
                      { 'Description': 'Lake Michigan from Wilmette Harbor IL to Michigan City IN 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ779.txt' },
                      { 'Description': 'Lake Michigan from Michigan City IN to St. Joseph MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ080.txt' },
                      { 'Description': 'Lake Michigan from St. Joseph to South Haven MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ878.txt' },
                      { 'Description': 'Lake Michigan from South Haven to Holland MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ876.txt' },
                      { 'Description': 'Lake Michigan from Holland to Grand Haven MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ874.txt' },
                      { 'Description': 'Lake Michigan from Grand Haven to Whitehall MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ872.txt' },
                      { 'Description': 'Lake Michigan from Whitehall to Pentwater MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ870.txt' },
                      { 'Description': 'Lake Michigan from Pentwater to Manistee MI 5 NM offshore to mid lake', 'url': '/great_lakes/LM/LMZ868.txt' }
                  ]
              },
              {
                  'title': 'Michigan Shore Line',
                  'forecasts':
                  [
                      { 'Description': 'Green Bay north of a line from Cedar River MI to Rock Island Passage', 'url': '/near_shore/LM/LMZ221.txt' },
                      { 'Description': 'Seul Choix Point to Point Detour MI', 'url': '/near_shore/LM/LMZ248.txt' },
                      { 'Description': '5 NM east of a line from Fairport MI to Rock Island Passage', 'url': '/near_shore/LM/LMZ250.txt' },
                      { 'Description': 'Seul Choix Point to 5 NM west of Mackinac Bridge', 'url': '/near_shore/LM/LMZ341.txt' },
                      { 'Description': 'Norwood MI to 5 NM west of Mackinac Bridge including Little Traverse Bay', 'url': '/near_shore/LM/LMZ342.txt' },
                      { 'Description': 'Grand Traverse Bay south of a line Grand Traverse Light to Norwood MI', 'url': '/near_shore/LM/LMZ323.txt' },
                      { 'Description': 'Sleeping Bear Point to Grand Traverse Light MI', 'url': '/near_shore/LM/LMZ344.txt' },
                      { 'Description': 'Point Betsie to Sleeping Bear Point MI', 'url': '/near_shore/LM/LMZ345.txt' },
                      { 'Description': 'Manistee to Point Betsie MI', 'url': '/near_shore/LM/LMZ346.txt' },
                      { 'Description': 'Pentwater to Manistee, MI', 'url': '/near_shore/LM/LMZ849.txt' },
                      { 'Description': 'Whitehall to Pentwater, MI', 'url': '/near_shore/LM/LMZ848.txt' },
                      { 'Description': 'Grand Haven to Whitehall, MI', 'url': '/near_shore/LM/LMZ847.txt' },
                      { 'Description': 'Holland to Grand Haven, MI', 'url': '/near_shore/LM/LMZ846.txt' },
                      { 'Description': 'South Haven to Holland, MI', 'url': '/near_shore/LM/LMZ845.txt' },
                      { 'Description': 'St. Joseph to South Haven, MI', 'url': '/near_shore/LM/LMZ844.txt' },
                      { 'Description': 'New Buffalo MI to St. Joseph, MI', 'url': '/near_shore/LM/LMZ043.txt' },
                      { 'Description': 'Michigan City, IN to New Buffalo, MI', 'url': '/near_shore/LM/LMZ046.txt' },
                  ]},
        {
        'title': 'Wisconsin Shore Line',
        'forecasts':
        [
            { 'Description': 'Green Bay south of line from Cedar River MI to Rock Island Passage and north of a line from Oconto WI to Little Sturgeon Bay WI', 'url': '/near_shore/LM/LMZ521.txt' },
            { 'Description': 'Green Bay south of a line from Oconto WI to Little Sturgeon Bay WI', 'url': '/near_shore/LM/LMZ522.txt' },
            { 'Description': 'Rock Island Passage to Sturgeon Bay WI', 'url': '/near_shore/LM/LMZ541.txt' },
            { 'Description': 'Sturgeon Bay to Two Rivers WI', 'url': '/near_shore/LM/LMZ542.txt' },
                      { 'Description': 'wo Rivers to Sheboygan WI', 'url': '/near_shore/LM/LMZ543.txt' },
                        { 'Description': 'Sheboygan to Port Washington, WI', 'url': '/near_shore/LM/LMZ643.txt' },
                        { 'Description': 'Port Washington to North Point Light, WI', 'url': '/near_shore/LM/LMZ644.txt' },
                        { 'Description': 'North Point Light to Wind Point, WI', 'url': '/near_shore/LM/LMZ645.txt' },
                        { 'Description': 'Wind Point to Winthrop Harbor, IL', 'url': '/near_shore/LM/LMZ646.txt' },
                  ]},
    {
        'title': 'Illinois Shore Line',
        'forecasts':
        [
            { 'Description': 'Winthrop Harbor to Wilmette Harbor, IL', 'url': '/near_shore/LM/LMZ740.txt' },
            { 'Description': 'Wilmette Harbor to Northerly Island, IL', 'url': '/near_shore/LM/LMZ741.txt' },
            { 'Description': 'Northerly Island to Calumet Harbor, IL', 'url': '/near_shore/LM/LMZ742.txt' },
        ]},
          {
              'title': 'Indiana Shore Line',
              'forecasts':
              [
                  { 'Description': 'Calumet Harbor to Gary, IN', 'url': '/near_shore/LM/LMZ743.txt' },
                  { 'Description': 'Gary to Burns Harbor, IN', 'url': '/near_shore/LM/LMZ744.txt' },
                  { 'Description': 'Burns Harbor to Michigan City, IN', 'url': '/near_shore/LM/LMZ745.txt' },
                  { 'Description': 'Michigan City, IN to New Buffalo, MI', 'url': '/near_shore/LM/LMZ046.txt' },
                  ]}
                ]
             },
        {
            'title': 'Lake Ontario',
            'subZones':
            [{
                'title': 'Lake Ontario Offshore',
                'forecasts':
                [
                    { 'Description': 'Lake Ontario', 'url': '/great_lakes/LO/LOZ061.txt' },
                    { 'Description': 'Niagara River to Hamlin Beach NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ062.txt' },
                    { 'Description': 'Hamlin Beach to Sodus Bay NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ063.txt' },
                    { 'Description': 'Sodus Bay to Mexico Bay NY beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ064.txt' },
                    { 'Description': 'Mexico Bay NY to the St. Lawrence River beyond 5 NM offshore to U.S./Canadian border', 'url': '/great_lakes/LO/LOZ065.txt' }
                ]
            },
             {
                 'title': 'New York Shore Line',
                 'forecasts':
 [
                     { 'Description': 'Niagara River to Hamlin Beach, NY', 'url': '/near_shore/LO/LOZ042.txt' },
                     { 'Description': 'Hamlin Beach to Sodus Bay, NY', 'url': '/near_shore/LO/LOZ043.txt' },
                     { 'Description': 'Sodus Bay to Mexico Bay, NY', 'url': '/near_shore/LO/LOZ044.txt' },
                     { 'Description': 'Mexico Bay, NY to the St. Lawrence River', 'url': '/near_shore/LO/LOZ045.txt' },
                     { 'Description': 'St. Lawrence River above Ogdensburg, NY', 'url': '/great_lakes/SL/SLZ022.txt' },
                     { 'Description': 'St. Lawrence River from Ogdensburg to St. Regis, NY', 'url': '/great_lakes/SL/SLZ024.txt' },
 ]
             }
            ]
        },
          {
              'title': 'Lake St. Clair',
              'subZones':
              [{
                  'title': 'Lake St. Clair Offshore (U.S. Portion)',
                  'forecasts':
                  [
                      { 'Description': 'Lake St. Clair (U.S. Portion)', 'url': '/great_lakes/LC/LCZ460.txt' }
                  ]
              },
               {
                   'title': 'Lake St. Clair Near Shore',
                   'forecasts':
                   [
                        { 'Description': 'St. Clair River', 'url': '/great_lakes/LC/LCZ422.txt' },
                        { 'Description': 'Lake St. Clair, MI (U.S. Portion)', 'url': '/great_lakes/LC/LCZ460.txt' },
                        { 'Description': 'Detroit River', 'url': '/great_lakes/LC/LCZ423.txt' }
                   ]
               }
              ]
          },
        {
            'title': 'Lake Superior',
            'subZones':
            [{
                'title': 'Offshore',
                'forecasts':
                [                   
                    { 'Description': 'Lake Superior MAFOR only', 'url': '/great_lakes/LS/LSZ261.txt' },
                    { 'Description': 'Lake Superior west of a line from Saxon Harbor WI to Grand Portage MN beyond 5 NM', 'url': '/great_lakes/LS/LSZ162.txt' },
                    { 'Description': 'Lake Superior from Saxon Harbor WI to Upper Entrance to Portage Canal MI 5 NM offshore to the U.S./Canadian border including Isle Royal National Park', 'url': '/great_lakes/LS/LSZ263.txt' },
                    { 'Description': 'Lake Superior from Upper Entrance to Portage Canal to Manitou Island MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LS/LSZ264.txt' },
                    { 'Description': 'Lake Superior east of a line from Manitou Island to Marquette MI and west of a line from Grand Marais MI to the U.S./Canadian border beyond 5 NM from shore', 'url': '/great_lakes/LS/LSZ265.txt' },
                    { 'Description': 'Lake Superior from Grand Marais MI to Whitefish Point MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LS/LSZ266.txt' },
                    { 'Description': 'Lake Superior from Grand Marais MI to Whitefish Point MI 5 NM offshore to the U.S./Canadian border', 'url': '/great_lakes/LS/LSZ267.txt' }
               ]
            },
            {
                'title': 'Minnesota Shore Line',
                'forecasts':
                [
                                { 'Description': 'Grand Portage to Grand Marais, MN', 'url': '/near_shore/LS/LSZ140.txt' },
                                { 'Description': 'Grand Marais to Taconite Harbor, MN', 'url': '/near_shore/LS/LSZ141.txt' },
                                { 'Description': 'Taconite Harbor to Silver Bay Harbor, MN', 'url': '/near_shore/LS/LSZ142.txt' },
                                { 'Description': 'Silver Bay Harbor to Two Harbors, MN', 'url': '/near_shore/LS/LSZ143.txt' },
                                { 'Description': 'Two Harbors to Duluth, MN', 'url': '/near_shore/LS/LSZ144.txt' },
                ]
            },
            {
                'title': 'Wisconsin Shore Line',
                'forecasts':
	            [
                                { 'Description': 'Duluth, MN to Port Wing, WI', 'url': '/near_shore/LS/LSZ145.txt' },
                                { 'Description': 'Port Wing to Sand Island, WI', 'url': '/near_shore/LS/LSZ146.txt' },
                                { 'Description': 'Sand Island to Bayfield, WI', 'url': '/near_shore/LS/LSZ147.txt' },
                                { 'Description': 'Chequamegon Bay-Bayfield to Oak Point, WI', 'url': '/near_shore/LS/LSZ121.txt' },
                                { 'Description': 'Oak Point to Saxon Harbor, WI', 'url': '/near_shore/LS/LSZ148.txt' }
	            ]
            },
            {
                'title': 'Michigan Shore Line',
                'forecasts':
	            [
                                { 'Description': 'Saxon Harbor WI to Black River MI', 'url': '/near_shore/LS/LSZ240.txt' },
                                { 'Description': 'Black River to Ontonagon MI', 'url': '/near_shore/LS/LSZ241.txt' },
                                { 'Description': 'Ontonagon to Upper Entrance of Portage Canal MI', 'url': '/near_shore/LS/LSZ242.txt' },
                                { 'Description': 'Upper Entrance of Portage Canal to Eagle River MI', 'url': '/near_shore/LS/LSZ243.txt' },
                                { 'Description': 'Eagle River to Manitou Island MI', 'url': '/near_shore/LS/LSZ244.txt' },
                                { 'Description': 'Manitou Island to Point Isabelle MI', 'url': '/near_shore/LS/LSZ245.txt' },
                                { 'Description': 'Point Isabelle to Lower Entrance of Portage Canal MI', 'url': '/near_shore/LS/LSZ246.txt' },
                                { 'Description': 'Lower Entrance of Portage Canal to Huron Islands MI including Keweenaw and Huron Bays', 'url': '/near_shore/LS/LSZ247.txt' },
                                { 'Description': 'Huron Islands to Marquette MI', 'url': '/near_shore/LS/LSZ248.txt' },
                                { 'Description': 'Marquette to Munising MI', 'url': '/near_shore/LS/LSZ249.txt' },
                                { 'Description': 'Munising to Grand Marais MI', 'url': '/near_shore/LS/LSZ250.txt' },
                                { 'Description': 'Grand Marais to Whitefish Point MI', 'url': '/near_shore/LS/LSZ251.txt' },
                                { 'Description': 'Whitefish Bay (U.S. Portion) Whitefish Point to Point Iroquois MI', 'url': '/near_shore/LS/LSZ321.txt' },
                                { 'Description': 'St. Marys River Point Iroquois to E. Potagannissing Bay to Eastern Potagannissing Bay', 'url': '/near_shore/LS/LSZ322.txt' },
	            ]
            }
            ]
        }
    ]
}]

