using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FF9
{
	public class __invalid_type__10000State
	{
		public string mode { get; set; }
		public string prevMode { get; set; }
		public string fldMapNo { get; set; }
		public string fldLocNo { get; set; }
		public string btlMapNo { get; set; }
		public string btlSubMapNo { get; set; }
		public string wldMapNo { get; set; }
		public string wldLocNo { get; set; }
		public string timeCounter { get; set; }
		public string timerControl { get; set; }
		public string timerDisplay { get; set; }
	}

	public class __invalid_type__20000Event
	{
		public string gStepCount { get; set; }
		public string gEventGlobal { get; set; }
	}

	public class MiniGameCard
	{
		public string id { get; set; }
		public string side { get; set; }
		public string atk { get; set; }
		public string type { get; set; }
		public string pdef { get; set; }
		public string mdef { get; set; }
		public string cpoint { get; set; }
		public string arrow { get; set; }
	}

	public class __invalid_type__30000MiniGame
	{
		public string sWin { get; set; }
		public string sLose { get; set; }
		public string sDraw { get; set; }
		public List<MiniGameCard> MiniGameCard { get; set; }
	}

	public class Cur
	{
		public string hp { get; set; }
		public string mp { get; set; }
		public string at { get; set; }
		public string at_coef { get; set; }
		public string capa { get; set; }
	}

	public class Max
	{
		public string hp { get; set; }
		public string mp { get; set; }
		public string at { get; set; }
		public string at_coef { get; set; }
		public string capa { get; set; }
	}

	public class Elem
	{
		public string dex { get; set; }
		public string str { get; set; }
		public string mgc { get; set; }
		public string wpr { get; set; }
	}

	public class Defence
	{
		public string p_def { get; set; }
		public string p_ev { get; set; }
		public string m_def { get; set; }
		public string m_ev { get; set; }
	}

	public class Basis
	{
		public string max_hp { get; set; }
		public string max_mp { get; set; }
		public string dex { get; set; }
		public string str { get; set; }
		public string mgc { get; set; }
		public string wpr { get; set; }
	}

	public class Info
	{
		public string slot_no { get; set; }
		public string serial_no { get; set; }
		public string row { get; set; }
		public string win_pose { get; set; }
		public string party { get; set; }
		public string menu_type { get; set; }
	}

	public class Bonus
	{
		public string dex { get; set; }
		public string str { get; set; }
		public string mgc { get; set; }
		public string wpr { get; set; }
	}

	public class Player
	{
		public string name { get; set; }
		public string category { get; set; }
		public string level { get; set; }
		public string exp { get; set; }
		public Cur cur { get; set; }
		public Max max { get; set; }
		public string trance { get; set; }
		public string web_bone { get; set; }
		public Elem elem { get; set; }
		public Defence defence { get; set; }
		public Basis basis { get; set; }
		public Info info { get; set; }
		public string status { get; set; }
		public List<string> equip { get; set; }
		public Bonus bonus { get; set; }
		public List<string> pa { get; set; }
		public List<string> sa { get; set; }
	}

	public class Item
	{
		public string id { get; set; }
		public string count { get; set; }
	}

	public class __invalid_type__40000Common
	{
		public List<Player> players { get; set; }
		public List<string> slot { get; set; }
		public string escape_no { get; set; }
		public string summon_flag { get; set; }
		public string gil { get; set; }
		public string frog_no { get; set; }
		public string steal_no { get; set; }
		public string dragon_no { get; set; }
		public List<Item> items { get; set; }
		public List<string> rareItems { get; set; }
	}

	public class Cfg
	{
		public string sound { get; set; }
		public string sound_effect { get; set; }
		public string control { get; set; }
		public string cursor { get; set; }
		public string atb { get; set; }
		public string camera { get; set; }
		public string move { get; set; }
		public string vibe { get; set; }
		public string btl_speed { get; set; }
		public string fld_msg { get; set; }
		public string here_icon { get; set; }
		public string win_type { get; set; }
		public string target_win { get; set; }
		public string control_data { get; set; }
		public List<string> control_data_keyboard { get; set; }
		public List<string> control_data_joystick { get; set; }
		public string skip_btl_camera { get; set; }
	}

	public class __invalid_type__50000Setting
	{
		public Cfg cfg { get; set; }
		public string time { get; set; }
	}

	public class __invalid_type__60000Sound
	{
		public string auto_save_bgm_id { get; set; }
	}

	public class __invalid_type__70000World
	{
		[JsonProperty("data.cameraState.rotationMax")]
		public string __invalid_name__data_cameraState_rotationMax { get; set; }
		[JsonProperty("data.cameraState.upperCounter")]
		public string __invalid_name__data_cameraState_upperCounter { get; set; }
		[JsonProperty("data.cameraState.upperCounterSpeed")]
		public string __invalid_name__data_cameraState_upperCounterSpeed { get; set; }
		[JsonProperty("data.cameraState.upperCounterForce")]
		public string __invalid_name__data_cameraState_upperCounterForce { get; set; }
		[JsonProperty("data.cameraState.rotation")]
		public string __invalid_name__data_cameraState_rotation { get; set; }
		[JsonProperty("data.cameraState.rotationRev")]
		public string __invalid_name__data_cameraState_rotationRev { get; set; }
		[JsonProperty("data.hintmap")]
		public string __invalid_name__data_hintmap { get; set; }
	}

	public class __invalid_type__80000Achievement
	{
		public List<string> AteCheckArray { get; set; }
		public List<string> EvtReservedArray { get; set; }
		public string blkMag_no { get; set; }
		public string whtMag_no { get; set; }
		public string bluMag_no { get; set; }
		public string summon_no { get; set; }
		public string enemy_no { get; set; }
		public string backAtk_no { get; set; }
		public string defence_no { get; set; }
		public string trance_no { get; set; }
		public List<string> abilities { get; set; }
		public List<string> passiveAbilities { get; set; }
		public string synthesisCount { get; set; }
		public string AuctionTime { get; set; }
		public string StiltzkinBuy { get; set; }
		public List<string> QuadmistWinList { get; set; }
	}

	public class __invalid_type__94000Common
	{
		[JsonProperty("00001_player_bonus")]
		public List<string> __invalid_name__00001_player_bonus { get; set; }
		[JsonProperty("99999_ReservedBuffer")]
		public List<string> __invalid_name__99999_ReservedBuffer { get; set; }
	}

	public class __invalid_type__95000Setting
	{
		[JsonProperty("00001_time")]
		public string __invalid_name__00001_time { get; set; }
		[JsonProperty("99999_ReservedBuffer")]
		public List<string> __invalid_name__99999_ReservedBuffer { get; set; }
	}

	public class __invalid_type__98000Achievement
	{
		[JsonProperty("00001_abnormal_status")]
		public string __invalid_name__00001_abnormal_status { get; set; }
		[JsonProperty("00002_summon_shiva")]
		public string __invalid_name__00002_summon_shiva { get; set; }
		[JsonProperty("00003_summon_ifrit")]
		public string __invalid_name__00003_summon_ifrit { get; set; }
		[JsonProperty("00004_summon_ramuh")]
		public string __invalid_name__00004_summon_ramuh { get; set; }
		[JsonProperty("00005_summon_carbuncle_reflector")]
		public string __invalid_name__00005_summon_carbuncle_reflector { get; set; }
		[JsonProperty("00006_summon_carbuncle_haste")]
		public string __invalid_name__00006_summon_carbuncle_haste { get; set; }
		[JsonProperty("00007_summon_carbuncle_protect")]
		public string __invalid_name__00007_summon_carbuncle_protect { get; set; }
		[JsonProperty("00008_summon_carbuncle_shell")]
		public string __invalid_name__00008_summon_carbuncle_shell { get; set; }
		[JsonProperty("00009_summon_fenrir_earth")]
		public string __invalid_name__00009_summon_fenrir_earth { get; set; }
		[JsonProperty("000010_summon_fenrir_wind")]
		public string __invalid_name__000010_summon_fenrir_wind { get; set; }
		[JsonProperty("000011_summon_atomos")]
		public string __invalid_name__000011_summon_atomos { get; set; }
		[JsonProperty("000012_summon_phoenix")]
		public string __invalid_name__000012_summon_phoenix { get; set; }
		[JsonProperty("000013_summon_leviathan")]
		public string __invalid_name__000013_summon_leviathan { get; set; }
		[JsonProperty("000014_summon_odin")]
		public string __invalid_name__000014_summon_odin { get; set; }
		[JsonProperty("000015_summon_madeen")]
		public string __invalid_name__000015_summon_madeen { get; set; }
		[JsonProperty("000016_summon_bahamut")]
		public string __invalid_name__000016_summon_bahamut { get; set; }
		[JsonProperty("000017_summon_arc")]
		public string __invalid_name__000017_summon_arc { get; set; }
		[JsonProperty("99999_ReservedBuffer")]
		public List<string> __invalid_name__99999_ReservedBuffer { get; set; }
	}

	public class Data
	{
		[JsonProperty("10000_State")]
		public __invalid_type__10000State __invalid_name__10000_State { get; set; }
		[JsonProperty("20000_Event")]
		public __invalid_type__20000Event __invalid_name__20000_Event { get; set; }
		[JsonProperty("30000_MiniGame")]
		public __invalid_type__30000MiniGame __invalid_name__30000_MiniGame { get; set; }
		[JsonProperty("40000_Common")]
		public __invalid_type__40000Common __invalid_name__40000_Common { get; set; }
		[JsonProperty("50000_Setting")]
		public __invalid_type__50000Setting __invalid_name__50000_Setting { get; set; }
		[JsonProperty("60000_Sound")]
		public __invalid_type__60000Sound __invalid_name__60000_Sound { get; set; }
		[JsonProperty("70000_World")]
		public __invalid_type__70000World __invalid_name__70000_World { get; set; }
		[JsonProperty("80000_Achievement")]
		public __invalid_type__80000Achievement __invalid_name__80000_Achievement { get; set; }
		[JsonProperty("91000_State")]
		public List<string> __invalid_name__91000_State { get; set; }
		[JsonProperty("92000_Event")]
		public List<string> __invalid_name__92000_Event { get; set; }
		[JsonProperty("93000_MiniGame")]
		public List<string> __invalid_name__93000_MiniGame { get; set; }
		[JsonProperty("94000_Common")]
		public __invalid_type__94000Common __invalid_name__94000_Common { get; set; }
		[JsonProperty("95000_Setting")]
		public __invalid_type__95000Setting __invalid_name__95000_Setting { get; set; }
		[JsonProperty("96000_Sound")]
		public List<string> __invalid_name__96000_Sound { get; set; }
		[JsonProperty("97000_World")]
		public List<string> __invalid_name__97000_World { get; set; }
		[JsonProperty("98000_Achievement")]
		public __invalid_type__98000Achievement __invalid_name__98000_Achievement { get; set; }
		[JsonProperty("99000_Other")]
		public List<string> __invalid_name__99000_Other { get; set; }
	}

	public class RootObject
	{
		public Data Data { get; set; }
	}
}
