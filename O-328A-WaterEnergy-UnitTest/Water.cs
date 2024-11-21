namespace O_328A_WaterEnergy_UnitTest;

public class Water
{
    private const double CaloriesMeltIcePerGram = 80;
    private const double CaloriesEvaporateWaterPerGram = 600;

    public double Temperature { get; private set; }
    public double Amount { get; private set; }
    public double Percentage { get; private set; }
    public WaterState State { get; private set; }
    public double ProportionFirstState;
    internal double Energy;
    

    public Water(double amount, double temperature, double? propotion = null)
    {
        Amount = amount;
        Temperature = temperature;

        State = temperature <= 0 ? WaterState.Ice
            : temperature > 100 ? WaterState.Gas
            : WaterState.Fluid;

        if (propotion == null && temperature is  100 or 0)
        {
            throw new ArgumentException("When temperature is 0 or 100, you must provide a value for proportion");
        }
        
        ProportionFirstState = propotion ?? 1; 
        if (ProportionFirstState == 1) return;
        if (ProportionFirstState == 0) State = temperature == 0 ? WaterState.Fluid : WaterState.Gas;
        else State = temperature == 0 ? WaterState.IceAndFluid : WaterState.FluidAndGas;
    }
    
    private void TransformAll(double wantedTemp, double energyToTransformAll)
    {
        Energy -= Math.Abs((wantedTemp - Temperature) * Amount); 
        Temperature = wantedTemp;
        Energy -= energyToTransformAll;
        
        if (Temperature < 100) State = WaterState.Fluid;
        if (Temperature >= 100) State = WaterState.Gas;
    }
    private void TransformSome(double energyToTransformAll, double energyToReachNextState, double wantedTemp)
    {
        if (Energy >= energyToTransformAll + energyToReachNextState) TransformAll(wantedTemp, energyToTransformAll);
        else if (Energy <= energyToTransformAll)
        {
            Energy -= Math.Abs((wantedTemp - Temperature) * Amount); 
            ProportionFirstState = 1 - Energy / energyToTransformAll;
            Energy = 0;
            Temperature= wantedTemp;
            if (Temperature is 0 && ProportionFirstState is not 0) State = WaterState.Fluid;
            if (Temperature is 0 && ProportionFirstState is 0) State = WaterState.IceAndFluid;
            if (Temperature is 100 && ProportionFirstState is not 0) State = WaterState.FluidAndGas;
            if (Temperature is 100 && ProportionFirstState is 0) State = WaterState.Gas;
        };
    }
    private void HeatTo(double requiredEnergy, int wantedTemp, int? something = null)
    {
        Temperature += Energy/Amount;
        Energy -= Energy;
    }
    public void AddEnergy(double calories)
    {
        Energy = calories;
            
        if (Temperature < 0 && Energy > 0)
        {
            var energyToZeroIce = Math.Abs(Temperature * Amount);
            var energyToTransformAll = Math.Abs(Amount * CaloriesMeltIcePerGram);
            if (Energy <= energyToZeroIce) HeatTo(energyToZeroIce, 0);
            if (Energy >= energyToZeroIce) TransformSome(energyToTransformAll, energyToZeroIce, 0);
        }

        if (Temperature < 100 && Energy > 0)
        {
            var energyToBoilWater = (100 - Temperature) * Amount;
            var energyToTransformAll = Math.Abs(Amount * CaloriesEvaporateWaterPerGram);
            if (Energy <= energyToBoilWater) HeatTo(energyToBoilWater, 100);
            if(Energy >= energyToBoilWater) TransformSome(energyToTransformAll, energyToBoilWater, 100);
        }
        
        if (Temperature >= 100 && Energy > 0)
        {
            var energyToVaporizeAllWater = CaloriesEvaporateWaterPerGram * Amount;
            if (Energy <= energyToVaporizeAllWater && State != WaterState.Gas) TransformSome(energyToVaporizeAllWater, 0,100 );
            if (Energy <= energyToVaporizeAllWater && State == WaterState.Gas) HeatTo(110,110);
            
        }
    }
}