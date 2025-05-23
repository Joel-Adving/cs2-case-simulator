import type { Skin } from '../types';
import { RARITY_ORDER } from '../constants';
import type { InventoryItem } from '~/services/inventoryDb';

export function sortSkinByRarity(a: Skin | InventoryItem, b: Skin | InventoryItem) {
    return RARITY_ORDER[a.rarity_id] - RARITY_ORDER[b.rarity_id];
}

export function gunSkinFilter(skin: Skin): boolean {
    return !skin?.name.includes('★');
}

export function knivesAndGlovesSkinFilter(skin: Skin | InventoryItem): boolean {
    return skin?.name.includes('★');
}

export function filterSkinsByOnlyKnives(skin: Skin): boolean {
    return skin?.name.includes('Knife');
}

export function filterSkinsByOnlyGloves(skin: Skin): boolean {
    const gloveKeywords = ['Glove', 'Wrap'];
    return gloveKeywords.some((word) => skin.name.includes(word));
}

export function sortSkinByName(a: Skin, b: Skin): number {
    return a.name.localeCompare(b.name);
}
