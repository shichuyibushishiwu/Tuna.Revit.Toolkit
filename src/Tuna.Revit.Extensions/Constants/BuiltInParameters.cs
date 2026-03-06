/************************************************************************************
/   Author:十五
/   CretaeTime:2023/3/9 0:30:51
/   Mail:1012201478@qq.com
/   Github:https://github.com/shichuyibushishiwu
/
/   Description:
/
/************************************************************************************/

using Autodesk.Revit.DB;

namespace Tuna.Revit.Extensions;

/// <summary>
/// Revit builtin parameters
/// </summary>
public class BuiltInParameters
{
    /// <summary>
    /// INVALID
    /// </summary>
    public static ElementId Invaild { get; } = new ElementId(BuiltInParameter.INVALID);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_MARK"/>
    /// </summary>
    public static ElementId Mark { get; } = new ElementId(BuiltInParameter.ALL_MODEL_MARK);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS"/>
    /// </summary>
    public static ElementId InstanceComments { get; } = new ElementId(BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_TYPE_COMMENTS"/>
    /// </summary>
    public static ElementId TypeComments { get; } = new ElementId(BuiltInParameter.ALL_MODEL_TYPE_COMMENTS);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_DESCRIPTION"/>
    /// </summary>
    public static ElementId Description { get; } = new ElementId(BuiltInParameter.ALL_MODEL_DESCRIPTION);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_MANUFACTURER"/>
    /// </summary>
    public static ElementId Manufacturer { get; } = new ElementId(BuiltInParameter.ALL_MODEL_MANUFACTURER);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_MODEL"/>
    /// </summary>
    public static ElementId Model { get; } = new ElementId(BuiltInParameter.ALL_MODEL_MODEL);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_TYPE_NAME"/>
    /// </summary>
    public static ElementId TypeName { get; } = new ElementId(BuiltInParameter.ALL_MODEL_TYPE_NAME);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_COST"/>
    /// </summary>
    public static ElementId Cost { get; } = new ElementId(BuiltInParameter.ALL_MODEL_COST);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_URL"/>
    /// </summary>
    public static ElementId Url { get; } = new ElementId(BuiltInParameter.ALL_MODEL_URL);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_FAMILY_NAME"/>
    /// </summary>
    public static ElementId FamilyName { get; } = new ElementId(BuiltInParameter.ALL_MODEL_FAMILY_NAME);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_IMAGE"/>
    /// </summary>
    public static ElementId Image { get; } = new ElementId(BuiltInParameter.ALL_MODEL_IMAGE);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_TYPE_IMAGE"/>
    /// </summary>
    public static ElementId TypeImage { get; } = new ElementId(BuiltInParameter.ALL_MODEL_TYPE_IMAGE);

    /// <summary>
    /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ALL_MODEL_TYPE_MARK"/>
    /// </summary>
    public static ElementId TypeMark { get; } = new ElementId(BuiltInParameter.ALL_MODEL_TYPE_MARK);

    /// <summary>
    /// Element
    /// </summary>
    public class Element
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ELEM_CATEGORY_PARAM"/>
        /// </summary>
        public static ElementId Category { get; } = new ElementId(BuiltInParameter.ELEM_CATEGORY_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ELEM_FAMILY_PARAM"/>
        /// </summary>
        public static ElementId Family { get; } = new ElementId(BuiltInParameter.ELEM_FAMILY_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ELEM_TYPE_PARAM"/>
        /// </summary>
        public static ElementId Type { get; } = new ElementId(BuiltInParameter.ELEM_TYPE_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ELEM_FAMILY_AND_TYPE_PARAM"/>
        /// </summary>
        public static ElementId FamilyAndType { get; } = new ElementId(BuiltInParameter.ELEM_FAMILY_AND_TYPE_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ELEM_PARTITION_PARAM"/>
        /// </summary>
        public static ElementId Workset { get; } = new ElementId(BuiltInParameter.ELEM_PARTITION_PARAM);
    }

    /// <summary>
    /// ProjectInformation
    /// </summary>
    public class ProjectInformation
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_NAME"/>
        /// </summary>
        public static ElementId Name { get; } = new ElementId(BuiltInParameter.PROJECT_NAME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_NUMBER"/>
        /// </summary>
        public static ElementId Number { get; } = new ElementId(BuiltInParameter.PROJECT_NUMBER);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_ADDRESS"/>
        /// </summary>
        public static ElementId Address { get; } = new ElementId(BuiltInParameter.PROJECT_ADDRESS);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_STATUS"/>
        /// </summary>
        public static ElementId Status { get; } = new ElementId(BuiltInParameter.PROJECT_STATUS);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_BUILDING_NAME"/>
        /// </summary>
        public static ElementId BuildingName { get; } = new ElementId(BuiltInParameter.PROJECT_BUILDING_NAME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_ISSUE_DATE"/>
        /// </summary>
        public static ElementId IssueDate { get; } = new ElementId(BuiltInParameter.PROJECT_ISSUE_DATE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_AUTHOR"/>
        /// </summary>
        public static ElementId Author { get; } = new ElementId(BuiltInParameter.PROJECT_AUTHOR);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PROJECT_ORGANIZATION_NAME"/>
        /// </summary>
        public static ElementId OrganizationName { get; } = new ElementId(BuiltInParameter.PROJECT_ORGANIZATION_NAME);
    }

    /// <summary>
    /// Type of view builtin parameters
    /// </summary>
    public class View
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_NAME"/>
        /// </summary>
        public static ElementId Name { get; } = new ElementId(BuiltInParameter.VIEW_NAME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_DESCRIPTION"/>
        /// </summary>
        public static ElementId Description { get; } = new ElementId(BuiltInParameter.VIEW_DESCRIPTION);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_TYPE"/>
        /// </summary>
        public static ElementId Type { get; } = new ElementId(BuiltInParameter.VIEW_TYPE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_SCALE"/>
        /// </summary>
        public static ElementId Scale { get; } = new ElementId(BuiltInParameter.VIEW_SCALE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_DETAIL_LEVEL"/>
        /// </summary>
        public static ElementId DetailLevel { get; } = new ElementId(BuiltInParameter.VIEW_DETAIL_LEVEL);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_DISCIPLINE"/>
        /// </summary>
        public static ElementId Discipline { get; } = new ElementId(BuiltInParameter.VIEW_DISCIPLINE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_PHASE"/>
        /// </summary>
        public static ElementId Phase { get; } = new ElementId(BuiltInParameter.VIEW_PHASE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_TEMPLATE"/>
        /// </summary>
        public static ElementId Template { get; } = new ElementId(BuiltInParameter.VIEW_TEMPLATE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_PHASE_FILTER"/>
        /// </summary>
        public static ElementId PhaseFilter { get; } = new ElementId(BuiltInParameter.VIEW_PHASE_FILTER);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_PARTS_VISIBILITY"/>
        /// </summary>
        public static ElementId PartsVisibility { get; } = new ElementId(BuiltInParameter.VIEW_PARTS_VISIBILITY);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_DEPTH"/>
        /// </summary>
        public static ElementId Depth { get; } = new ElementId(BuiltInParameter.VIEW_DEPTH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_UNDERLAY_BOTTOM_ID"/>
        /// </summary>
        public static ElementId UnderlayBottomId { get; } = new ElementId(BuiltInParameter.VIEW_UNDERLAY_BOTTOM_ID);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_UNDERLAY_TOP_ID"/>
        /// </summary>
        public static ElementId UnderlayTopId { get; } = new ElementId(BuiltInParameter.VIEW_UNDERLAY_TOP_ID);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_UNDERLAY_ORIENTATION"/>
        /// </summary>
        public static ElementId UnderlayOrientation { get; } = new ElementId(BuiltInParameter.VIEW_UNDERLAY_ORIENTATION);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_MODEL_DISPLAY_MODE"/>
        /// </summary>
        public static ElementId ModelDisplayMode { get; } = new ElementId(BuiltInParameter.VIEW_MODEL_DISPLAY_MODE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_CLEAN_JOINS"/>
        /// </summary>
        public static ElementId CleanJoins { get; } = new ElementId(BuiltInParameter.VIEW_CLEAN_JOINS);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.VIEW_BACK_CLIPPING"/>
        /// </summary>
        public static ElementId BackClipping { get; } = new ElementId(BuiltInParameter.VIEW_BACK_CLIPPING);
    }

    /// <summary>
    /// Sheet of view builtin parameters
    /// </summary>
    public class Sheet
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_NAME"/>
        /// </summary>
        public static ElementId Name { get; } = new ElementId(BuiltInParameter.SHEET_NAME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_NUMBER"/>
        /// </summary>
        public static ElementId Number { get; } = new ElementId(BuiltInParameter.SHEET_NUMBER);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_SCALE"/>
        /// </summary>
        public static ElementId Scale { get; } = new ElementId(BuiltInParameter.SHEET_SCALE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_DATE"/>
        /// </summary>
        public static ElementId Date { get; } = new ElementId(BuiltInParameter.SHEET_DATE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_WIDTH"/>
        /// </summary>
        public static ElementId Width { get; } = new ElementId(BuiltInParameter.SHEET_WIDTH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_HEIGHT"/>
        /// </summary>
        public static ElementId Height { get; } = new ElementId(BuiltInParameter.SHEET_HEIGHT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_DESIGNED_BY"/>
        /// </summary>
        public static ElementId DesignedBy { get; } = new ElementId(BuiltInParameter.SHEET_DESIGNED_BY);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_DRAWN_BY"/>
        /// </summary>
        public static ElementId DrawnBy { get; } = new ElementId(BuiltInParameter.SHEET_DRAWN_BY);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_CHECKED_BY"/>
        /// </summary>
        public static ElementId CheckedBy { get; } = new ElementId(BuiltInParameter.SHEET_CHECKED_BY);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_APPROVED_BY"/>
        /// </summary>
        public static ElementId ApprovedBy { get; } = new ElementId(BuiltInParameter.SHEET_APPROVED_BY);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_ISSUE_DATE"/>
        /// </summary>
        public static ElementId IssueDate { get; } = new ElementId(BuiltInParameter.SHEET_ISSUE_DATE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_FILE_PATH"/>
        /// </summary>
        public static ElementId FilePath { get; } = new ElementId(BuiltInParameter.SHEET_FILE_PATH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_CURRENT_REVISION"/>
        /// </summary>
        public static ElementId CurrentRevision { get; } = new ElementId(BuiltInParameter.SHEET_CURRENT_REVISION);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_CURRENT_REVISION_DATE"/>
        /// </summary>
        public static ElementId CurrentRevisionDate { get; } = new ElementId(BuiltInParameter.SHEET_CURRENT_REVISION_DATE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_GUIDE_GRID"/>
        /// </summary>
        public static ElementId GuideGrid { get; } = new ElementId(BuiltInParameter.SHEET_GUIDE_GRID);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_SCHEDULED"/>
        /// </summary>
        public static ElementId Scheduled { get; } = new ElementId(BuiltInParameter.SHEET_SCHEDULED);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_REVISIONS_ON_SHEET"/>
        /// </summary>
        public static ElementId RevisionsOnSheet { get; } = new ElementId(BuiltInParameter.SHEET_REVISIONS_ON_SHEET);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SHEET_KEY_NUMBER"/>
        /// </summary>
        public static ElementId KeyNumber { get; } = new ElementId(BuiltInParameter.SHEET_KEY_NUMBER);
    }

    /// <summary>
    /// Level of view builtin parameters
    /// </summary>
    public class Level
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_NAME"/>
        /// </summary>
        public static ElementId Name { get; } = new ElementId(BuiltInParameter.LEVEL_NAME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_ELEV"/>
        /// </summary>
        public static ElementId Elevation { get; } = new ElementId(BuiltInParameter.LEVEL_ELEV);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_IS_BUILDING_STORY"/>
        /// </summary>
        public static ElementId IsBuildingStory { get; } = new ElementId(BuiltInParameter.LEVEL_IS_BUILDING_STORY);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_IS_STRUCTURAL"/>
        /// </summary>
        public static ElementId IsStructural { get; } = new ElementId(BuiltInParameter.LEVEL_IS_STRUCTURAL);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_UP_TO_LEVEL"/>
        /// </summary>
        public static ElementId UpToLevel { get; } = new ElementId(BuiltInParameter.LEVEL_UP_TO_LEVEL);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_RELATIVE_BASE_TYPE"/>
        /// </summary>
        public static ElementId RelativeBaseType { get; } = new ElementId(BuiltInParameter.LEVEL_RELATIVE_BASE_TYPE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_ROOM_COMPUTATION_HEIGHT"/>
        /// </summary>
        public static ElementId RoomComputationHeight { get; } = new ElementId(BuiltInParameter.LEVEL_ROOM_COMPUTATION_HEIGHT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.LEVEL_HEAD_TAG"/>
        /// </summary>
        public static ElementId HeadTag { get; } = new ElementId(BuiltInParameter.LEVEL_HEAD_TAG);
    }

    /// <summary>
    /// Symbol of view builtin parameters
    /// </summary>
    public class Symbol
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SYMBOL_NAME_PARAM"/>
        /// </summary>
        public static ElementId Name { get; } = new ElementId(BuiltInParameter.SYMBOL_NAME_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SYMBOL_FAMILY_NAME_PARAM"/>
        /// </summary>
        public static ElementId FamilyName { get; } = new ElementId(BuiltInParameter.SYMBOL_FAMILY_NAME_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.SYMBOL_FAMILY_AND_TYPE_NAMES_PARAM"/>
        /// </summary>
        public static ElementId FamilyAndTypeNames { get; } = new ElementId(BuiltInParameter.SYMBOL_FAMILY_AND_TYPE_NAMES_PARAM);
    }

    /// <summary>
    /// Room of view builtin parameters
    /// </summary>
    public class Room
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_NAME"/>
        /// </summary>
        public static ElementId Name { get; } = new ElementId(BuiltInParameter.ROOM_NAME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_NUMBER"/>
        /// </summary>
        public static ElementId Number { get; } = new ElementId(BuiltInParameter.ROOM_NUMBER);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_AREA"/>
        /// </summary>
        public static ElementId Area { get; } = new ElementId(BuiltInParameter.ROOM_AREA);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_DEPARTMENT"/>
        /// </summary>
        public static ElementId Department { get; } = new ElementId(BuiltInParameter.ROOM_DEPARTMENT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_HEIGHT"/>
        /// </summary>
        public static ElementId Height { get; } = new ElementId(BuiltInParameter.ROOM_HEIGHT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_PHASE"/>
        /// </summary>
        public static ElementId Phase { get; } = new ElementId(BuiltInParameter.ROOM_PHASE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_VOLUME"/>
        /// </summary>
        public static ElementId Volume { get; } = new ElementId(BuiltInParameter.ROOM_VOLUME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_PERIMETER"/>
        /// </summary>
        public static ElementId Perimeter { get; } = new ElementId(BuiltInParameter.ROOM_PERIMETER);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_OCCUPANCY"/>
        /// </summary>
        public static ElementId Occupancy { get; } = new ElementId(BuiltInParameter.ROOM_OCCUPANCY);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_NUMBER_OF_PEOPLE_PARAM"/>
        /// </summary>
        public static ElementId NumberOfPeople { get; } = new ElementId(BuiltInParameter.ROOM_NUMBER_OF_PEOPLE_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_UPPER_OFFSET"/>
        /// </summary>
        public static ElementId UpperOffset { get; } = new ElementId(BuiltInParameter.ROOM_UPPER_OFFSET);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_LOWER_OFFSET"/>
        /// </summary>
        public static ElementId LowerOffset { get; } = new ElementId(BuiltInParameter.ROOM_LOWER_OFFSET);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_LEVEL_ID"/>
        /// </summary>
        public static ElementId LevelId { get; } = new ElementId(BuiltInParameter.ROOM_LEVEL_ID);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_UPPER_LEVEL"/>
        /// </summary>
        public static ElementId UpperLevel { get; } = new ElementId(BuiltInParameter.ROOM_UPPER_LEVEL);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_FINISH_CEILING"/>
        /// </summary>
        public static ElementId FinishCeiling { get; } = new ElementId(BuiltInParameter.ROOM_FINISH_CEILING);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_FINISH_FLOOR"/>
        /// </summary>
        public static ElementId FinishFloor { get; } = new ElementId(BuiltInParameter.ROOM_FINISH_FLOOR);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_FINISH_WALL"/>
        /// </summary>
        public static ElementId FinishWall { get; } = new ElementId(BuiltInParameter.ROOM_FINISH_WALL);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOM_FINISH_BASE"/>
        /// </summary>
        public static ElementId FinishBase { get; } = new ElementId(BuiltInParameter.ROOM_FINISH_BASE);
    }

    /// <summary>
    /// Datum
    /// </summary>
    public class Datum
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DATUM_TEXT"/>
        /// </summary>
        public static ElementId Text { get; } = new ElementId(BuiltInParameter.DATUM_TEXT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DATUM_BUBBLE_END_1"/>
        /// </summary>
        public static ElementId BubbleEnd1 { get; } = new ElementId(BuiltInParameter.DATUM_BUBBLE_END_1);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DATUM_BUBBLE_END_2"/>
        /// </summary>
        public static ElementId BubbleEnd2 { get; } = new ElementId(BuiltInParameter.DATUM_BUBBLE_END_2);
    }


    /// <summary>
    /// Phase
    /// </summary>
    public class Phase
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PHASE_NAME"/>
        /// </summary>
        public static ElementId Name { get; } = new ElementId(BuiltInParameter.PHASE_NAME);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.PHASE_CREATED"/>
        /// </summary>
        public static ElementId Created { get; } = new ElementId(BuiltInParameter.PHASE_CREATED);
    }

    /// <summary>
    /// Wall
    /// </summary>
    public class Wall
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WALL_BASE_CONSTRAINT"/>
        /// </summary>
        public static ElementId BaseConstraint { get; } = new ElementId(BuiltInParameter.WALL_BASE_CONSTRAINT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WALL_BASE_OFFSET"/>
        /// </summary>
        public static ElementId BaseOffset { get; } = new ElementId(BuiltInParameter.WALL_BASE_OFFSET);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WALL_TOP_OFFSET"/>
        /// </summary>
        public static ElementId TopOffset { get; } = new ElementId(BuiltInParameter.WALL_TOP_OFFSET);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WALL_HEIGHT_TYPE"/>
        /// </summary>
        public static ElementId HeightType { get; } = new ElementId(BuiltInParameter.WALL_HEIGHT_TYPE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WALL_USER_HEIGHT_PARAM"/>
        /// </summary>
        public static ElementId UnconnectedHeight { get; } = new ElementId(BuiltInParameter.WALL_USER_HEIGHT_PARAM);
    }

    /// <summary>
    /// Floor
    /// </summary>
    public class Floor
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM"/>
        /// </summary>
        public static ElementId HeightAboveLevel { get; } = new ElementId(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.FLOOR_PARAM_IS_STRUCTURAL"/>
        /// </summary>
        public static ElementId IsStructural { get; } = new ElementId(BuiltInParameter.FLOOR_PARAM_IS_STRUCTURAL);
    }

    /// <summary>
    /// Roof
    /// </summary>
    public class Roof
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOF_BASE_LEVEL_PARAM"/>
        /// </summary>
        public static ElementId BaseLevel { get; } = new ElementId(BuiltInParameter.ROOF_BASE_LEVEL_PARAM);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.ROOF_LEVEL_OFFSET_PARAM"/>
        /// </summary>
        public static ElementId LevelOffset { get; } = new ElementId(BuiltInParameter.ROOF_LEVEL_OFFSET_PARAM);
    }

    /// <summary>
    /// Ceiling
    /// </summary>
    public class Ceiling
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.CEILING_HEIGHTABOVELEVEL_PARAM"/>
        /// </summary>
        public static ElementId HeightAboveLevel { get; } = new ElementId(BuiltInParameter.CEILING_HEIGHTABOVELEVEL_PARAM);
    }

    /// <summary>
    /// Door
    /// </summary>
    public class Door
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_NUMBER"/>
        /// </summary>
        public static ElementId Number { get; } = new ElementId(BuiltInParameter.DOOR_NUMBER);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_WIDTH"/>
        /// </summary>
        public static ElementId Width { get; } = new ElementId(BuiltInParameter.DOOR_WIDTH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_HEIGHT"/>
        /// </summary>
        public static ElementId Height { get; } = new ElementId(BuiltInParameter.DOOR_HEIGHT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_THICKNESS"/>
        /// </summary>
        public static ElementId Thickness { get; } = new ElementId(BuiltInParameter.DOOR_THICKNESS);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_FIRE_RATING"/>
        /// </summary>
        public static ElementId FireRating { get; } = new ElementId(BuiltInParameter.DOOR_FIRE_RATING);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_OPERATION_TYPE"/>
        /// </summary>
        public static ElementId OperationType { get; } = new ElementId(BuiltInParameter.DOOR_OPERATION_TYPE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_FRAME_MATERIAL"/>
        /// </summary>
        public static ElementId FrameMaterial { get; } = new ElementId(BuiltInParameter.DOOR_FRAME_MATERIAL);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_FINISH"/>
        /// </summary>
        public static ElementId Finish { get; } = new ElementId(BuiltInParameter.DOOR_FINISH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_COST"/>
        /// </summary>
        public static ElementId Cost { get; } = new ElementId(BuiltInParameter.DOOR_COST);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DOOR_FRAME_TYPE"/>
        /// </summary>
        public static ElementId FrameType { get; } = new ElementId(BuiltInParameter.DOOR_FRAME_TYPE);
    }

    /// <summary>
    /// Window
    /// </summary>
    public class Window
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WINDOW_WIDTH"/>
        /// </summary>
        public static ElementId Width { get; } = new ElementId(BuiltInParameter.WINDOW_WIDTH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WINDOW_HEIGHT"/>
        /// </summary>
        public static ElementId Height { get; } = new ElementId(BuiltInParameter.WINDOW_HEIGHT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WINDOW_THICKNESS"/>
        /// </summary>
        public static ElementId Thickness { get; } = new ElementId(BuiltInParameter.WINDOW_THICKNESS);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WINDOW_OPERATION_TYPE"/>
        /// </summary>
        public static ElementId OperationType { get; } = new ElementId(BuiltInParameter.WINDOW_OPERATION_TYPE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WINDOW_INSET"/>
        /// </summary>
        public static ElementId Inset { get; } = new ElementId(BuiltInParameter.WINDOW_INSET);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WINDOW_TYPE_ID"/>
        /// </summary>
        public static ElementId TypeId { get; } = new ElementId(BuiltInParameter.WINDOW_TYPE_ID);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.WINDOW_CONSTRUCTION_TYPE"/>
        /// </summary>
        public static ElementId ConstructionType { get; } = new ElementId(BuiltInParameter.WINDOW_CONSTRUCTION_TYPE);
    }

    /// <summary>
    /// Instance
    /// </summary>
    public class Instance
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.INSTANCE_SILL_HEIGHT_PARAM"/>
        /// </summary>
        public static ElementId SillHeight { get; } = new ElementId(BuiltInParameter.INSTANCE_SILL_HEIGHT_PARAM);
    }

    /// <summary>
    /// TextNote
    /// </summary>
    public class TextNote
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.TEXT_TEXT"/>
        /// </summary>
        public static ElementId Text { get; } = new ElementId(BuiltInParameter.TEXT_TEXT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.TEXT_FONT"/>
        /// </summary>
        public static ElementId Font { get; } = new ElementId(BuiltInParameter.TEXT_FONT);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.TEXT_SIZE"/>
        /// </summary>
        public static ElementId Size { get; } = new ElementId(BuiltInParameter.TEXT_SIZE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.TEXT_WIDTH_SCALE"/>
        /// </summary>
        public static ElementId WidthScale { get; } = new ElementId(BuiltInParameter.TEXT_WIDTH_SCALE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.TEXT_TAB_SIZE"/>
        /// </summary>
        public static ElementId TabSize { get; } = new ElementId(BuiltInParameter.TEXT_TAB_SIZE);
    }

    /// <summary>
    /// Dimension
    /// </summary>
    public class Dimension
    {
        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DIM_VALUE_LENGTH"/>
        /// </summary>
        public static ElementId ValueLength { get; } = new ElementId(BuiltInParameter.DIM_VALUE_LENGTH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DIM_VALUE_ANGLE"/>
        /// </summary>
        public static ElementId ValueAngle { get; } = new ElementId(BuiltInParameter.DIM_VALUE_ANGLE);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DIM_TOTAL_LENGTH"/>
        /// </summary>
        public static ElementId TotalLength { get; } = new ElementId(BuiltInParameter.DIM_TOTAL_LENGTH);

        /// <summary>
        /// <see cref="Autodesk.Revit.DB.BuiltInParameter.DIM_REFERENCE_COUNT"/>
        /// </summary>
        public static ElementId ReferenceCount { get; } = new ElementId(BuiltInParameter.DIM_REFERENCE_COUNT);
    }
}
