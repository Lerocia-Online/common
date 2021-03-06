namespace Lerocia.Items.Apparel {
  using Characters;

  public class BaseApparel : BaseItem {
    private int armor;

    public BaseApparel(
      int id, 
      string name, 
      int weight, 
      int value, 
      int armor
    ) : base(
      id, 
      name, 
      weight, 
      value, 
      "Apparel"
    ) {
      this.armor = armor;
      AddStat("Armor", armor.ToString());
    }

    public int GetArmor() {
      return armor;
    }

    private void Equip(Character character) {
      if (character.ApparelId != GetId()) {
        character.ApparelId = GetId();
      } else {
        character.ApparelId = -1;
      }
      character.UpdateStats();
    }
  
    public override void Use(Character character) {
      Equip(character);
    }
  }
}