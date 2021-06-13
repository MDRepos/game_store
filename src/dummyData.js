class products {
    static games() {
        return [
            {
                id:1,
                name:'Fifa 2021',
                description:'Last edition of Fifa serie from EA-Sports',
                year:2021,
                platform:['PS', 'XBOX', 'WINDOWS'],
                price: 60,
                imageUrl:'https://media.contentapi.ea.com/content/dam/ea/fifa/fifa-21/global_assets/common/featured_images/fifa-21-grid-tile-generic-16x9.jpg.adapt.crop16x9.1023w.jpg'
            }, 
            {
                id:2,
                name:'PES 2021',
                description:'Last edition of Pro Evolution Soccer serie from EA-Sports',
                year:2021,
                platform:['PS', 'XBOX', 'WINDOWS'],
                price: 35,
                imageUrl:'https://image.api.playstation.com/vulcan/img/rnd/202011/0201/DCT1LwEUb8fXfS2PZfkzXV59.png'
            },
            {
                id:3,
                name:'Far Cry 6',
                description:'Jump into the action and chaos of guerrilla combat using an arsenal of unique weapons',
                year:2021,
                platform:['PS', 'XBOX', 'WINDOWS'],
                price: 67,
                imageUrl:'https://staticctf.akamaized.net/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/4MgHhyrHH13oYwXezEy7Wy/56985f97b3e3cc78e06c67ca0a054b32/FC6_meta-image__1_.jpg'
            },
            {
                id:4,
                name:'Hitman 3',
                description:'Agent 47 returns as a ruthless professional in HITMAN 3 for the most important contracts of his entire career',
                year:2021,
                platform:['PS', 'XBOX', 'WINDOWS', 'Nitendo'],
                price: 55,
                imageUrl:'https://image.api.playstation.com/vulcan/ap/rnd/202007/3011/ujyNY9YV9TnDcDA62425NUwW.png'
            },
            {
                id:5,
                name:'Halo Infinite',
                description:'The Master Chief returns in the next chapter of the legendary franchise in Halo Infinite.',
                year:2021,
                platform:['XBOX', 'WINDOWS'],
                price: 38,
                imageUrl:'https://cdn.mos.cms.futurecdn.net/nrEpzWY86sMnMvr6LgTSmi.jpg'
            },
            {
                id:6,
                name:'GhostWire: Tokyo',
                description:'Action and advetures game',
                year:2021,
                platform:['PS', 'XBOX', 'WINDOWS'],
                price: 24,
                imageUrl:'https://img.prisguiden.no/3129/3129869/ghostwire_tokyo_qhd-2060x1151.2048x1144m.jpg'
            }     
        ]
    }

    static consoles(){
        return[
            {
                id:10,
                name: 'Play Station 5',
                price: 670,
                imageUrl:'https://cdn.mos.cms.futurecdn.net/6hFVUfpXZrj4TADPnmswTd-1200-80.jpg'
            },
                        {
                id:11,
                name: 'Play Station 4',
                price: 340,
                imageUrl:'https://cdn.mos.cms.futurecdn.net/KnyAxGTfiqdssHHq2VkbF9-480-80.jpg'
            },
                        {
                id:12,
                name: 'XBOX Series S',
                price: 320,
                imageUrl:'https://www.komplett.no/img/p/1169/1168808.jpg'
            },
            {
                id:13,
                name: 'XBOX Series X',
                price: 650,
                imageUrl:'https://www.komplett.no/marketingmedia/68843/projectred-oo-16x9.jpg'
            },
            {
                id:14,
                name: 'Nitendo Switch',
                price: 350,
                imageUrl:'https://www.elkjop.no/image/dv_web_D180001002263821/48150/nintendo-switch-spillkonsoll-2019-med-neon-blaaroed-joy-con-kontrollere.jpg?$fullsize$'
            },
        ]
    }

    static extra(){
        return[
            {
                id:20,
                name:'KOTION EACH G2000',
                price:19,
                imageUrl:'https://li0.rightinthebox.com/images/640x640/202011/enisap1605597579466.jpg'
            },
            {
                id:21,
                name:'NOS Z-300 3-i-1-pakkage',
                price:63,
                imageUrl:'https://www.elkjop.no/image/dv_web_D180001002507710/200750/nos-z-300-3-i-1-pakke-med-headsettastaturmus-for-gaming.jpg'
            },
            {
                id:22,
                name:'Svive Leo Studio-sett',
                price:120,
                imageUrl:'https://www.komplett.no/img/p/1200/1162220.jpg'
            },
            {
                id:23,
                name:'Logitech G733 Lightspeed RGB',
                price:100,
                imageUrl:'https://www.elkjop.no/image/dv_web_D180001002519369/195401/logitech-g733-lightspeed-rgb-gaming-headset-svart.jpg?'
            },
            {
                id:24,
                name:'Razer Power Up gamingsett',
                price:110,
                imageUrl:'https://www.elkjop.no/image/dv_web_D180001002510856/216063/razer-power-up-gamingsett.jpg'
            },
            {
                id:25,
                name:'Razer Kishi for iPhone',
                price:95,
                imageUrl:'https://www.komplett.no/img/p/1200/1178088.jpg'
            },
        ]
    }
}

export default products;