﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurora.Profiles.LeagueOfLegends.GSI.Nodes;
using System.Drawing;

namespace Aurora.Profiles.LeagueOfLegends.Layers
{
    public static class DefaultChampionColors
    {
        public static Dictionary<Champion, Color> GetDictionary() => new Dictionary<Champion, Color>()
        {
            [Champion.Undefined] = Color.FromArgb(120,120,120),
            [Champion.Amumu] = Color.FromArgb(140, 190, 98),
            [Champion.Azir] = Color.FromArgb(225, 121, 20),
            [Champion.Braum] = Color.FromArgb(42, 180, 208),
            [Champion.Corki] = Color.FromArgb(236, 172, 76),
            [Champion.Draven] = Color.FromArgb(164, 84, 76),
            [Champion.Diana] = Color.FromArgb(64, 64, 191),
            [Champion.Fizz] = Color.FromArgb(76, 148, 188),
            [Champion.Galio] = Color.FromArgb(75, 108, 169),
            [Champion.Hecarim] = Color.FromArgb(30, 244, 244),
            [Champion.Jhin] = Color.FromArgb(164, 38, 94),
            [Champion.Jayce] = Color.FromArgb(144, 57, 41),
            [Champion.Kayle] = Color.FromArgb(242, 189, 82),
            [Champion.Khazix] = Color.FromArgb(86, 38, 195),
            [Champion.Leblanc] = Color.FromArgb(180, 60, 76),
            [Champion.LeeSin] = Color.FromArgb(212, 34, 76),
            [Champion.Nidalee] = Color.FromArgb(189, 135, 92),
            [Champion.Orianna] = Color.FromArgb(200, 118, 55),
            [Champion.Ryze] = Color.FromArgb(60, 95, 199),
            [Champion.Senna] = Color.FromArgb(68, 148, 100),
            [Champion.Swain] = Color.FromArgb(156, 25, 14),
            [Champion.Taliyah] = Color.FromArgb(233, 119, 25),
            [Champion.Thresh] = Color.FromArgb(16, 223, 113),
            [Champion.TwistedFate] = Color.FromArgb(164, 100, 76),
            [Champion.Vladimir] = Color.FromArgb(204, 68, 60),
            [Champion.Volibear] = Color.FromArgb(68, 135, 178),
            [Champion.Warwick] = Color.FromArgb(158, 94, 76),
            [Champion.Xerath] = Color.FromArgb(60, 98, 198),
            [Champion.Ziggs] = Color.FromArgb(196, 134, 84),
            [Champion.Aatrox] = Color.FromArgb(244, 68, 68),
            [Champion.Akali] = Color.FromArgb(156, 68, 100),
            [Champion.Ahri] = Color.FromArgb(72, 93, 221),
            [Champion.Annie] = Color.FromArgb(188, 100, 59),
            [Champion.Alistar] = Color.FromArgb(104, 68, 176),
            [Champion.Anivia] = Color.FromArgb(8, 128, 200),
            [Champion.Aphelios] = Color.FromArgb(52, 44, 124),
            [Champion.Ashe] = Color.FromArgb(30, 39, 182),
            [Champion.AurelionSol] = Color.FromArgb(52, 28, 180),
            [Champion.Bard] = Color.FromArgb(236, 150, 32),
            [Champion.Blitzcrank] = Color.FromArgb(208, 132, 52),
            [Champion.Caitlyn] = Color.FromArgb(84, 172, 204),
            [Champion.Camille] = Color.FromArgb(148, 84, 60),
            [Champion.Brand] = Color.FromArgb(196, 76, 36),
            [Champion.Cassiopeia] = Color.FromArgb(181, 120, 76),
            [Champion.Chogath] = Color.FromArgb(140, 68, 172),
            [Champion.Darius] = Color.FromArgb(180, 4, 20),
            [Champion.Ekko] = Color.FromArgb(164, 40, 68),
            [Champion.DrMundo] = Color.FromArgb(44, 164, 180),
            [Champion.Evelynn] = Color.FromArgb(186, 55, 167),
            [Champion.Ezreal] = Color.FromArgb(180, 108, 68),
            [Champion.Fiddlesticks] = Color.FromArgb(60, 244, 172),
            [Champion.Fiora] = Color.FromArgb(204, 41, 98),
            [Champion.Elise] = Color.FromArgb(140, 28, 52),
            [Champion.Gangplank] = Color.FromArgb(228, 60, 12),
            [Champion.Gragas] = Color.FromArgb(196, 72, 36),
            [Champion.Gnar] = Color.FromArgb(244, 124, 36),
            [Champion.Illaoi] = Color.FromArgb(172, 116, 52),
            [Champion.Graves] = Color.FromArgb(181, 79, 68),
            [Champion.Garen] = Color.FromArgb(42, 84, 216),
            [Champion.Ivern] = Color.FromArgb(156, 145, 73),
            [Champion.Heimerdinger] = Color.FromArgb(64, 156, 216),
            [Champion.Irelia] = Color.FromArgb(188, 60, 76),
            [Champion.Janna] = Color.FromArgb(76, 152, 192),
            [Champion.Jax] = Color.FromArgb(126, 74, 181),
            [Champion.JarvanIV] = Color.FromArgb(236, 188, 20),
            [Champion.Jinx] = Color.FromArgb(62, 138, 202),
            [Champion.Kaisa] = Color.FromArgb(104, 52, 128),
            [Champion.Kalista] = Color.FromArgb(40, 184, 228),
            [Champion.Karthus] = Color.FromArgb(132, 196, 204),
            [Champion.Katarina] = Color.FromArgb(204, 12, 76),
            [Champion.Karma] = Color.FromArgb(52, 201, 162),
            [Champion.Kassadin] = Color.FromArgb(228, 196, 100),
            [Champion.Kayn] = Color.FromArgb(212, 43, 212),
            [Champion.Kennen] = Color.FromArgb(244, 212, 36),
            [Champion.Kindred] = Color.FromArgb(68, 204, 228),
            [Champion.Kled] = Color.FromArgb(156, 92, 4),
            [Champion.KogMaw] = Color.FromArgb(156, 128, 64),
            [Champion.Leona] = Color.FromArgb(196, 113, 35),
            [Champion.Lissandra] = Color.FromArgb(60, 100, 168),
            [Champion.Lucian] = Color.FromArgb(212, 156, 124),
            [Champion.Lulu] = Color.FromArgb(184, 84, 84),
            [Champion.Lux] = Color.FromArgb(204, 116, 72),
            [Champion.Malphite] = Color.FromArgb(161, 161, 46),
            [Champion.Malzahar] = Color.FromArgb(168, 24, 220),
            [Champion.Maokai] = Color.FromArgb(40, 132, 160),
            [Champion.MasterYi] = Color.FromArgb(194, 162, 68),
            [Champion.MissFortune] = Color.FromArgb(220, 108, 44),
            [Champion.MonkeyKing] = Color.FromArgb(239, 62, 33),
            [Champion.Mordekaiser] = Color.FromArgb(44, 164, 124),
            [Champion.Morgana] = Color.FromArgb(233, 57, 228),
            [Champion.Nasus] = Color.FromArgb(134, 51, 204),
            [Champion.Neeko] = Color.FromArgb(103, 71, 190),
            [Champion.Nami] = Color.FromArgb(36, 188, 232),
            [Champion.Nautilus] = Color.FromArgb(244, 99, 38),
            [Champion.Nunu] = Color.FromArgb(28, 124, 236),
            [Champion.Nocturne] = Color.FromArgb(28, 148, 212),
            [Champion.Olaf] = Color.FromArgb(228, 142, 43),
            [Champion.Ornn] = Color.FromArgb(206, 32, 106),
            [Champion.Poppy] = Color.FromArgb(201, 38, 81),
            [Champion.Pyke] = Color.FromArgb(50, 104, 98),
            [Champion.Qiyana] = Color.FromArgb(244, 98, 23),
            [Champion.Pantheon] = Color.FromArgb(76, 138, 179),
            [Champion.Quinn] = Color.FromArgb(172, 84, 76),
            [Champion.Rakan] = Color.FromArgb(132, 28, 52),
            [Champion.Rammus] = Color.FromArgb(209, 117, 33),
            [Champion.RekSai] = Color.FromArgb(44, 212, 244),
            [Champion.Renekton] = Color.FromArgb(188, 96, 39),
            [Champion.Rengar] = Color.FromArgb(174, 121, 62),
            [Champion.Rumble] = Color.FromArgb(204, 56, 36),
            [Champion.Riven] = Color.FromArgb(140, 44, 20),
            [Champion.Sejuani] = Color.FromArgb(32, 158, 215),
            [Champion.Sett] = Color.FromArgb(172, 76, 92),
            [Champion.Shaco] = Color.FromArgb(156, 44, 76),
            [Champion.Shen] = Color.FromArgb(83, 91, 189),
            [Champion.Shyvana] = Color.FromArgb(180, 76, 20),
            [Champion.Singed] = Color.FromArgb(92, 230, 82),
            [Champion.Skarner] = Color.FromArgb(100, 76, 204),
            [Champion.Sion] = Color.FromArgb(180, 9, 12),
            [Champion.Sivir] = Color.FromArgb(190, 108, 40),
            [Champion.Sona] = Color.FromArgb(90, 148, 185),
            [Champion.Soraka] = Color.FromArgb(212, 144, 84),
            [Champion.Syndra] = Color.FromArgb(160, 52, 232),
            [Champion.Sylas] = Color.FromArgb(108, 132, 188),
            [Champion.TahmKench] = Color.FromArgb(132, 100, 60),
            [Champion.Talon] = Color.FromArgb(92, 156, 244),
            [Champion.Taric] = Color.FromArgb(139, 100, 245),
            [Champion.Teemo] = Color.FromArgb(200, 96, 38),
            [Champion.Trundle] = Color.FromArgb(91, 142, 178),
            [Champion.Tristana] = Color.FromArgb(180, 60, 78),
            [Champion.Tryndamere] = Color.FromArgb(68, 172, 140),
            [Champion.Twitch] = Color.FromArgb(65, 157, 71),
            [Champion.Udyr] = Color.FromArgb(196, 84, 44),
            [Champion.Urgot] = Color.FromArgb(92, 196, 76),
            [Champion.Varus] = Color.FromArgb(193, 5, 74),
            [Champion.Veigar] = Color.FromArgb(249, 220, 30),
            [Champion.Vayne] = Color.FromArgb(228, 20, 52),
            [Champion.Velkoz] = Color.FromArgb(197, 58, 196),
            [Champion.Viktor] = Color.FromArgb(204, 76, 36),
            [Champion.Vi] = Color.FromArgb(196, 55, 100),
            [Champion.Xayah] = Color.FromArgb(174, 30, 92),
            [Champion.XinZhao] = Color.FromArgb(201, 132, 98),
            [Champion.Yorick] = Color.FromArgb(146, 206, 202),
            [Champion.Zac] = Color.FromArgb(212, 204, 36),
            [Champion.Yasuo] = Color.FromArgb(60, 140, 220),
            [Champion.Zed] = Color.FromArgb(196, 100, 58),
            [Champion.Yuumi] = Color.FromArgb(40, 104, 192),
            [Champion.Zilean] = Color.FromArgb(76, 164, 180),
            [Champion.Zoe] = Color.FromArgb(206, 82, 76),
            [Champion.Zyra] = Color.FromArgb(180, 52, 68)
        };
    }
}
