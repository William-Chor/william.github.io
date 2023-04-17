-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1
-- 產生時間： 2023 年 04 月 16 日 20:16
-- 伺服器版本： 10.4.24-MariaDB
-- PHP 版本： 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `finalyearproject`
--

-- --------------------------------------------------------

--
-- 資料表結構 `blacklist`
--

CREATE TABLE `blacklist` (
  `id` int(11) NOT NULL,
  `numberPlate` varchar(15) DEFAULT NULL,
  `reason` mediumtext DEFAULT NULL COMMENT 'Reason for why in the blacklist.'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `blacklist`
--

INSERT INTO `blacklist` (`id`, `numberPlate`, `reason`) VALUES
(2, 'MF328', 'I don\'t like it.'),
(3, 'VL842', 'Just Test'),
(4, '', '');

-- --------------------------------------------------------

--
-- 資料表結構 `message`
--

CREATE TABLE `message` (
  `messageID` int(11) NOT NULL,
  `postID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `content` mediumtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `message`
--

INSERT INTO `message` (`messageID`, `postID`, `userID`, `content`) VALUES
(1, 1, 1, 'Admin, could I test something in here?'),
(2, 1, 1, 'Admin, could I test something in here?'),
(3, 1, 1, 'Admin, could I test something in here?'),
(4, 1, 1, 'Admin, could I test something in here?'),
(5, 1, 1, 'Just Test');

-- --------------------------------------------------------

--
-- 資料表結構 `posts`
--

CREATE TABLE `posts` (
  `id` int(11) NOT NULL,
  `uId` int(11) NOT NULL,
  `title` varchar(100) NOT NULL,
  `content` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `posts`
--

INSERT INTO `posts` (`id`, `uId`, `title`, `content`) VALUES
(1, 2, 'Test this Post is the first', 'This is the Test Post, and the First Post, let me test somethink.'),
(4, 2, '其實係香港地又真係幾難唔買Tesla', '住新界出九龍番工 一年行2萬里\r\n普通油車 淨油費基本都3萬 仲要油魔係咁加#[sosad]#fs\r\n正常保養換下油 一年又洗多你5000左右\r\n\r\n我出一部電車 保你電池8年\r\n都慳左8年油錢+保養錢=30000x8+5000x8=280000$\r\n仲未計牌費#[sosad]#fs\r\n\r\n而我買電車 唔要支那牌子\r\n得Tesla 一間無markup過個價錢 一換一之後真係抵\r\n其他寶馬 Benz 代理markup哂個價 食埋你1換1個差價\r\n\r\n係外國無1換1 買新Tesla仲貴過Benz c200\r\n係豪車象徵[slick]'),
(5, 1, '[年經] 一人一個垃圾教車師傅', '元駕何sir，估唔到香港駕駛學院都會有垃圾師傅\r\n\r\n學車果陣寸貢貢下下窒撚住晒，又係咁反問我點解唔識，都唔知點撚樣答佢￼[sosad][sosad]日日上堂就鳩噏啲低能比喻，講咗好似冇講咁，唯一教到我嘅嘢就係教院嗰套理論(eg泊位邊啲位扭軚)。第二堂出街已經係咁話我考唔到牌要補堂，錯多幾次就冇耐性教喺到停車屌鬼，但其實都係講廢話。\r\n\r\n臨考前又話我晒錢炒硬咁濟，考前果一刻仲同我講路試你唔得㗎啦，考好個中期試冇咁柒，完全唔知講嚟有乜居心，最後pass左仲好意思叫我比多千幾蚊跟佢繼續學個咩路路通[sosad][sosad]￼比條毛你就有￼\r\n\r\n結果自己上網睇YouTube仲講解得好過佢，爬頭對頭有車/大貨車駛人要停都冇強調過(因為冇乜點發生過呢個情況)我唔上網睇Fai Sir都唔知。[sosad][sosad]\r\n\r\n\r\nBtw睇返連登先知原來之前已經有人屌過\r\n香港駕駛學院，元朗馬sir果然專業\r\nhttps://lih.kg/toksGoX\r\n#230 回覆 - 分享自 LIHKG 討論區\r\n\r\n教得好唔好就見仁見智，我就覺得佢好廢，但態度唔好就一定[sosad]見到佢教可以即刻轉師傅，比成皮嘢無謂受氣'),
(6, 1, '網傳新娘潭非法賽車　最少兩車疑拆牌鬥車　20歲男涉5罪被捕', '近日網上流傳多段影片，有人在新娘潭及鹿頸一帶進行非法賽車，有片段拍得3輛私家車緊貼追逐，過彎時亦未見減速，有車輛更一度橫越雙白線；另一段片段則拍得兩車輛疑似拆走車牌鬥車，行徑囂張。附近有多人圍觀吶喊助威，更舉起手機錄低賽車奔馳一刻。網上又流傳對話截圖，指有車手疑與對方「賭牌簿」，輸家需轉讓愛車予對方。\r\n\r\n警方表示，留意到網上流傳影片，經調查後相信在周三（12日）凌晨發生，並於今日（15日）凌晨採取執法行動，在上水區拘捕一名20歲本地男子涉嫌5罪，包括「非法賽車」、「危險駕駛」、「駕駛時沒有有效駕駛執照」、「駕駛沒有第三者保險的車輛」及「駕駛未獲發牌照的車輛」，不排除會有更多人被捕。'),
(7, 2, 'VW 車友吹水區 (4)', '幫手開返先#:)2#lny\r\n\r\nVW車型簡介#yup#\r\n\r\nVW只有一款車型叫高爾夫\r\n\r\n大眾只有一款車：高爾夫。拉長就是帕薩特(Passat)，改名就叫邁騰(Magotan)，減掉一個後座就是CC，再拉長就叫輝騰(Phaeton)，拍成方的就是途安(Touran)，加多三個後座就是夏朗(Sharan)，加高底盤就是途觀(Tiguan)，再撐大點就是途銳(Touareg)，拍扁就是尚酷(Scirocco)，加個屁股就是速騰(Jetta)，縮短點是POLO，搓圓了就是甲殼蟲\r\n\r\nPost 1: VW Golf 車友吹水區 https://lih.kg/2715519\r\n\r\nPost 2: VW 車友吹水區 (2) https://lih.kg/2859023\r\n\r\nPost 3: VW Golf 車友吹水區 (3) https://lih.kg/3041381'),
(8, 2, 'BENZ 車主討論區', '渣緊2018 年 C200\r\n打滿一剛油大約1300蚊左右\r\n之前入加得快 普通 行到600KM\r\n試左中石化垃圾油 燒得好快 行得450到\r\n諗住加尾翼大家覺得有無用?'),
(9, 1, '唸深一層，其實香港重有咩可以支撐樓市？', '本身巳經貴絕全球，而家人才又無，得d低端新香港人落黎囉福利。我見過班人才信都未識寄，靠呢班精英，你地真係有期咩？\r\n重有班拖喼水貨客人才可以幫到香港經濟咩？唔影響民生都算偷笑????????\r\n最後，香港無咩特別先進技術，好多都係靠買番黎。政府又係咁洗錢，我都唸唔到有咩出路'),
(10, 1, '本港1月份汽車銷售統計 Tesla大跌近8成 BYD首次賣贏Tesla', '（星島日報報道）運輸署本月初公布2023年1月份本地車市統計，全月私家車（新車）登記量2,530輛，較去年12月大跌28.5%。不過電動車繼續主導大市，其中國產品牌比亞迪（BYD）更首次壓倒Tesla，登上私家車十大排名榜第一位。 自從2022年第四季起，比亞迪電動車銷量穩步上揚，去年交付了491輛新車，未能躋身十大排行榜，不過踏入2023年1月份，比亞迪憑着344輛登記數量，歷史性登上香港私家車交投榜首位，超越了去年「長勝將軍」Tesla（316輛）。\r\n\r\n上月底（3月31日），比亞迪位於灣仔及尖沙嘴兩家陳列室同步開幕，標誌品牌在港發展邁進新里程。香港代理聯大汽車行政總裁張景榮透露，品牌將持續擴充銷售網絡，除了快將在九龍灣再添新店，還落實今年底在灣仔合和中心開設逾5千方呎新店。售後服務方面，全新元朗4S旗艦中心已投入運作，下半年還會在九龍灣增設面積超過8萬方呎的大型維修中心。\r\n\r\n張景榮強調，在車廠全力支持下，有信心今年實現銷量8千輛（或佔三成市場份額）預設目標，並於3年內成為本地私家車市場銷售冠軍。新車方面，海豹（Seal）電動房跑車預期第4季抵港，主打的700km長續航後驅版「一換一」意向價可望低於45萬元。擁有400km續航力的海豚（Dolphin）入門電動小車也快將推出，「一換一」售價不超過20萬元。\r\n\r\nTesla減價刺激銷路\r\n\r\n回看1月份本地私家車登記量，Tesla大跌近八成，但相信與去年底內地廠房短暫停產影響供應有關。不過據知2月份Tesla在港新車登記數字回升至1,400餘輛水平，應可重登榜首。Tesla香港日前宣布減價，減幅多達14.7%，相信可刺激銷路。德國「雙B」方面，平治（Mercedes-Benz）與寶馬（BMW）1月份以299輛及233輛分列第三位和第四位，兩者數字較去年12月回落超過兩成，相信也是貨源短缺所致。平治香港回應查詢，指電動新車供應趨向穩定，交付期可望由現時約5個月縮短至約4個月。\r\n\r\n疫情後本港市況復常、經濟回穩，今年1月份共2,530輛新車登記量中，電動車佔了1,521輛，比例大幅攀升至60.1%（去年同期佔比24.7%），充分反映電動車備受用家追捧。國產電動車品牌來勢洶洶，由英之傑集團代理的Maxus，首款MIFA 9純電動豪華MPV今日（4月14日）在港登場，市場盛傳再有兩個內地電車品牌今夏來港，令車市百花齊放。\r\n\r\n市場盛傳再有兩個內地電車品牌今夏來港? 大家估下係邊2個牌子？#wail#pig'),
(11, 2, '得罪講句，香港地唔係有小朋友或者狗仔，養架車真係曬鳩氣', '單身渣黎溝女車震都還好\r\n\r\n兩公婆邊有咁好心力成日渣出街周圍去\r\n\r\n番工中環渣車泊車慘過食屎\r\n\r\n求方便日日Uber好撚過仲平d');

-- --------------------------------------------------------

--
-- 資料表結構 `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `email` varchar(255) NOT NULL,
  `numberPlate` varchar(15) NOT NULL,
  `password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- 傾印資料表的資料 `users`
--

INSERT INTO `users` (`id`, `username`, `email`, `numberPlate`, `password`) VALUES
(1, 'Will', 'will@gmail.com', 'NY8711', '12345678'),
(2, 'Admin', 'admin', 'ADMIN', 'admin'),
(3, '', '', '', ''),
(4, NULL, '87@gmail.com', 'NY6888', '87654321'),
(5, NULL, '76@gmail.com', 'NN7777', '123456'),
(6, NULL, '12@gmail.com', 'NU8888', '456789'),
(7, NULL, 'william@gmail.com', 'PQ2123', '123456788'),
(8, 'WilliamC', 'willC@gmail.com', 'PQ5861', '876543211');

--
-- 已傾印資料表的索引
--

--
-- 資料表索引 `blacklist`
--
ALTER TABLE `blacklist`
  ADD PRIMARY KEY (`id`);

--
-- 資料表索引 `message`
--
ALTER TABLE `message`
  ADD PRIMARY KEY (`messageID`),
  ADD KEY `postID` (`postID`),
  ADD KEY `userID` (`userID`);

--
-- 資料表索引 `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`id`),
  ADD KEY `uId` (`uId`);

--
-- 資料表索引 `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- 在傾印的資料表使用自動遞增(AUTO_INCREMENT)
--

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `blacklist`
--
ALTER TABLE `blacklist`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `message`
--
ALTER TABLE `message`
  MODIFY `messageID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `posts`
--
ALTER TABLE `posts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- 使用資料表自動遞增(AUTO_INCREMENT) `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `message`
--
ALTER TABLE `message`
  ADD CONSTRAINT `message_ibfk_1` FOREIGN KEY (`postID`) REFERENCES `posts` (`id`),
  ADD CONSTRAINT `message_ibfk_2` FOREIGN KEY (`userID`) REFERENCES `users` (`id`);

--
-- 資料表的限制式 `posts`
--
ALTER TABLE `posts`
  ADD CONSTRAINT `posts_ibfk_1` FOREIGN KEY (`uId`) REFERENCES `users` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
