namespace WSUniversalLib
{
    public class Calculation
    {
        // Метод для расчета необходимого материала
        public static int GetQuantityForProduct(int count, float width, float length, int materialType, int productType)
        {
            if (count == 0 || width == 0 || length == 0 || materialType == 0 || productType == 0)
            {
                return -1;
            }

            // Вычисляем площадь изделия
            float area = width * length;
            // Коэффициент расхода материала в зависимости от типа изделия
            double coefficient = 0;

            switch (productType)
            {
                case 1:
                    coefficient = 1.1;
                    break;
                case 2:
                    coefficient = 2.5;
                    break;
                case 3:
                    coefficient = 8.43;
                    break;
                default:
                    return -1;
            }

            // Расход материала в зависимости от типа материала
            double materialWaste = 0;

            switch (materialType)
            {
                case 1:
                    materialWaste = 0.003;
                    break;
                case 2:
                    materialWaste = 0.0012;
                    break;
                default:
                    return -1;
            }

            // Общий расход материала
            double totalMaterial = count * area * coefficient / (1 - materialWaste);

            // Округление в большую сторону
            return (int)Math.Ceiling(totalMaterial);
        }
    }
}