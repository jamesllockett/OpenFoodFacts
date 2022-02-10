using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFoodFacts.Importer
{
    internal class FoodConstants
    {
        public const string HeaderCode = "code";
        public const string HeaderUrl = "url";
        public const string HeaderCreator = "creator";
        public const string HeaderCreatedTimestamp = "created_t";
        public const string HeaderCreated = "created_datetime";
        public const string HeaderLastModifiedTimestamp = "last_modified_t";
        public const string HeaderLastModified = "last_modified_datetime";
        public const string HeaderProductName = "product_name";
        public const string HeaderProductNameAbbr = "abbreviated_product_name";
        public const string HeaderGenericName = "generic_name";
        public const string HeaderQuantity = "quantity";
        public const string HeaderPackaging = "packaging";
        public const string HeaderPackagingTags = "packaging_tags";
        public const string HeaderPackagingText = "packaging_text";
        public const string HeaderBrands = "brands";
        public const string HeaderBrandTags = "brands_tags";
        public const string HeaderCategories = "categories";
        public const string HeaderCategoryTags = "categories_tags";
        public const string HeaderCategoriesEn = "categories_en";
        public const string HeaderOrigins = "origins";
        public const string HeaderOriginTags = "origins_tags";
        public const string HeaderOriginsEn = "origins_en";
        public const string HeaderManufacturingPlaces = "manufacturing_places";
        public const string HeaderManufacturingPlaceTags = "manufacturing_places_tags";
        public const string HeaderLabels = "labels";
        public const string HeaderLabelTags = "labels_tags";
        public const string HeaderLabelsEnd = "labels_en";
        public const string HeaderEMBCodes = "emb_codes";
        public const string HeaderEMBCodeTags = "emb_codes_tags";
        public const string HeaderFirstPackagingCodeGeo = "first_packaging_code_geo";
        public const string HeaderCities = "cities";
        public const string HeaderCityTags = "cities_tags";
        public const string HeaderPurchasePlaces = "purchase_places";
        public const string HeaderStores = "stores";
        public const string HeaderCountries = "countries";
        public const string HeaderCountryTags = "countries_tags";
        public const string HeaderCountriesEn = "countries_en";
        public const string HeaderIngredientsText = "ingredients_text";
        public const string HeaderAllergens = "allergens";
        public const string HeaderAllergensEn = "allergens_en";
        public const string HeaderTraces = "traces";
        public const string HeaderTraceTags = "traces_tags";
        public const string HeaderTracesEn = "traces_en";
        public const string HeaderServingSize = "serving_size";
        public const string HeaderServingQuantity = "serving_quantity";
        public const string HeaderNutrientNumber = "no_nutriments";
        public const string HeaderAdditivesNumber = "additives_n";
        public const string HeaderAdditives = "additives";
        public const string HeaderAdditiveTags = "additives_tags";
        public const string HeaderAdditivesEn = "additives_en";
        public const string HeaderIngredientsPalmOilNumber = "ingredients_from_palm_oil_n";
        public const string HeaderIngredientsPalmOil = "ingredients_from_palm_oil";
        public const string HeaderIngredientsPalmOilTags = "ingredients_from_palm_oil_tags";
        public const string HeaderPotentialIngredientsPalmOilNumber = "ingredients_that_may_be_from_palm_oil_n";
        public const string HeaderPotentialIngredientsPalmOil = "ingredients_that_may_be_from_palm_oil";
        public const string HeaderPotentialIngredientsPalmOilTags = "ingredients_that_may_be_from_palm_oil_tags";
        public const string HeaderNutriscore = "nutriscore_score";
        public const string HeaderNutriscoreGrade = "nutriscore_grade";
        public const string HeaderNovaGroup = "nova_group";
        public const string HeaderPNNSGroup1 = "pnns_groups_1";
        public const string HeaderPNNSGroup2 = "pnns_groups_2";
        public const string HeaderFoodGroups = "food_groups";
        public const string HeaderFoodGroupTags = "food_groups_tags";
        public const string HeaderFoodGroupsEn = "food_groups_en";
        public const string HeaderStates = "states";
        public const string HeaderStateTags = "states_tags";
        public const string HeaderStatesEn = "states_en";
        public const string HeaderBrandOwner = "brand_owner";
        public const string HeaderEcoScoreFr = "ecoscore_score_fr";
        public const string HeaderEcoScoreGradeFr = "ecoscore_grade_fr";
        public const string HeaderMainCategory = "main_category";
        public const string HeaderMainCategoryEn = "main_category_en";
        public const string HeaderImageURL = "image_url";
        public const string HeaderImageURLSmall = "image_small_url";
        public const string HeaderIngredientsImageURL = "image_ingredients_url";
        public const string HeaderIngredientsImageURLSmall = "image_ingredients_small_url";
        public const string HeaderNutritionImageURL = "image_nutrition_url";
        public const string HeaderNutritionImageURLSmall = "image_nutrition_small_url";
        public const string HeaderEnergyKJPer100G = "energy-kj_100g";
        public const string HeaderEnergyKCalPer100G = "energy-kcal_100g";
        public const string HeaderEnergyPer100G = "energy_100g";
        public const string HeaderEnergyFromFatPer100G = "energy-from-fat_100g";
        public const string HeaderFatPer100G = "fat_100g";
        public const string HeaderSaturatedFatPer100G = "saturated-fat_100g";
        public const string HeaderButyricAcidPer100G = "-butyric-acid_100g";
        public const string HeaderCaproicAcidPer100G = "-caproic-acid_100g";
        public const string HeaderCaprylicAcidPer100G = "-caprylic-acid_100g";
        public const string HeaderCapricAcidPer100G = "-capric-acid_100g";
        public const string HeaderLauricAcidPer100G = "-lauric-acid_100g";
        public const string HeaderMyristicAcidPer100G = "-myristic-acid_100g";
        public const string HeaderPalmiticAcidPer100G = "-palmitic-acid_100g";
        public const string HeaderStearicAcidPer100G = "-stearic-acid_100g";
        public const string HeaderArachidicAcidPer100G = "-arachidic-acid_100g";
        public const string HeaderBehenicAcidPer100G = "-behenic-acid_100g";
        public const string HeaderLignocericAcidPer100G = "-lignoceric-acid_100g";
        public const string HeaderCeroticAcidPer100G = "-cerotic-acid_100g";
        public const string HeaderMontanicAcidPer100G = "-montanic-acid_100g";
        public const string HeaderMelissicAcidPer100G = "-melissic-acid_100g";
        public const string HeaderMonosaturatedFatPer100G = "monounsaturated-fat_100g";
        public const string HeaderPolyunsaturatedFatPer100G = "polyunsaturated-fat_100g";
        public const string HeaderOmega3FatPer100G = "omega-3-fat_100g";
        public const string HeaderAlpaLinolenicAcidPer100G = "-alpha-linolenic-acid_100g";
        public const string HeaderEicosapentaenoicAcidPer100G = "-eicosapentaenoic-acid_100g";
        public const string HeaderDocosahexaenoicAcidPer100G = "-docosahexaenoic-acid_100g";
        public const string HeaderOmega6FatPer100G = "omega-6-fat_100g";
        public const string HeaderLinoleicAcidPer100G = "-linoleic-acid_100g";
        public const string HeaderArachidonicAcidPer100G = "-arachidonic-acid_100g";
        /*
                "-gamma-linolenic-acid_100g",
                "-dihomo-gamma-linolenic-acid_100g",
                "omega-9-fat_100g",
                "-oleic-acid_100g",
                "-elaidic-acid_100g",
                "-gondoic-acid_100g",
                "-mead-acid_100g",
                "-erucic-acid_100g",
                "-nervonic-acid_100g",
                "trans-fat_100g",
                "cholesterol_100g",
                "carbohydrates_100g",
                "sugars_100g",
                "-sucrose_100g",
                "-glucose_100g",
                "-fructose_100g",
                "-lactose_100g",
                "-maltose_100g",
                "-maltodextrins_100g",
                "starch_100g",
                "polyols_100g",
                "fiber_100g",
                "soluble-fiber_100g",
                "insoluble-fiber_100g",*/

        public const string HeaderProteinsPer100G = "proteins_100g";
        public const string HeaderCaseinPer100G = "casein_100g";
        public const string HeaderSerumProteinsPer100G = "serum-proteins_100g";
        public const string HeaderNucleotidesPer100G = "nucleotides_100g";
        public const string HeaderSaltPer100G = "salt_100g";
        public const string HeaderSodiumPer100G = "sodium_100g";
        public const string HeaderAlcoholPer100G = "alcohol_100g";
        public const string HeaderVitaminAPer100G = "vitamin-a_100g";
        public const string HeaderBetaCarotenePer100G = "beta-carotene_100g";
        public const string HeaderVitaminDPer100G = "vitamin-d_100g";
        public const string HeaderVitaminEPer100G = "vitamin-e_100g";
        public const string HeaderVitaminKPer100G = "vitamin-k_100g";
        public const string HeaderVitaminCPer100G = "vitamin-c_100g";
        public const string HeaderVitaminB1Per100G = "vitamin-b1_100g";
        public const string HeaderVitaminB2Per100G = "vitamin-b2_100g";
        public const string HeaderVitaminPPPer100G = "vitamin-pp_100g";
        public const string HeaderVitaminB6Per100G = "vitamin-b6_100g";
        public const string HeaderVitaminB9Per100G = "vitamin-b9_100g";
        public const string HeaderFolatesPer100G = "folates_100g";
        public const string HeaderVitaminB12Per100G = "vitamin-b12_100g";
        public const string HeaderBiotinPer100G = "biotin_100g";
        /*
                "pantothenic-acid_100g",
                "silica_100g",
                "bicarbonate_100g",
                "potassium_100g",
                "chloride_100g",
                "calcium_100g",
                "phosphorus_100g",
                "iron_100g",
                "magnesium_100g",
                "zinc_100g",
                "copper_100g",
                "manganese_100g",
                "fluoride_100g",
                "selenium_100g",
                "chromium_100g",
                "molybdenum_100g",
                "iodine_100g",
                "caffeine_100g",
                "taurine_100g",
                "ph_100g",
                "fruits-vegetables-nuts_100g",
                "fruits-vegetables-nuts-dried_100g",
                "fruits-vegetables-nuts-estimate_100g",
                "fruits-vegetables-nuts-estimate-from-ingredients_100g",
                "collagen-meat-protein-ratio_100g",
                "cocoa_100g",
                "chlorophyl_100g",
                "carbon-footprint_100g",
                "carbon-footprint-from-meat-or-fish_100g",
                "nutrition-score-fr_100g",
                "nutrition-score-uk_100g",
                "glycemic-index_100g",
                "water-hardness_100g",*/
        public const string HeaderCholinePer100G = "choline_100g";
        public const string HeaderPhylloquinonePer100G = "phylloquinone_100g";
        public const string HeaderBetaGlucanPer100G = "beta-glucan_100g";
        public const string HeaderInositolPer100G = "inositol_100g";
        public const string HeaderCarnitinePer100G = "carnitine_100g";
    }
}
