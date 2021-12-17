using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MapAssist.Settings;
using MapAssist.Types;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace MapAssist.Helpers
{

    internal sealed class MapColorConfigurationTypeConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(MapColorConfiguration);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            throw new NotImplementedException();
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

            var node = (MapColorConfiguration)value;
            if (node.Walkable != null)
            {
                var col = (Color)node.Walkable;
                emitter.Emit(new Scalar(null, "Walkable"));
                emitter.Emit(new Scalar(null, col.R + ", " + col.G + ", " + col.B));
            }
            if (node.Border != null)
            {
                var col = (Color)node.Border;
                emitter.Emit(new Scalar(null, "Border"));
                emitter.Emit(new Scalar(null, col.R + ", " + col.G + ", " + col.B));
            }

            emitter.Emit(new MappingEnd());
        }
    }
    internal sealed class PortalRenderingTypeConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(PortalRendering);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            throw new NotImplementedException();
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

            var node = (PortalRendering)value;
            if (node.IconColor != null)
            {
                emitter.Emit(new Scalar(null, "IconColor"));
                emitter.Emit(new Scalar(null, node.IconColor.A + ", " + node.IconColor.R + ", " + node.IconColor.G + ", " + node.IconColor.B));
                emitter.Emit(new Scalar(null, "IconShape"));
                emitter.Emit(new Scalar(null, node.IconShape.ToString()));
                emitter.Emit(new Scalar(null, "IconSize"));
                emitter.Emit(new Scalar(null, node.IconSize.ToString()));
                emitter.Emit(new Scalar(null, "IconThickness"));
                emitter.Emit(new Scalar(null, node.IconThickness.ToString()));
            }
            if (node.LineColor != null)
            {
                emitter.Emit(new Scalar(null, "LineColor"));
                emitter.Emit(new Scalar(null, node.LineColor.A + ", " + node.LineColor.R + ", " + node.LineColor.G + ", " + node.LineColor.B));
                emitter.Emit(new Scalar(null, "LineThickness"));
                emitter.Emit(new Scalar(null, node.LineThickness.ToString()));
                emitter.Emit(new Scalar(null, "ArrowHeadSize"));
                emitter.Emit(new Scalar(null, node.ArrowHeadSize.ToString()));
            }
            if (node.LabelColor != null)
            {
                emitter.Emit(new Scalar(null, "LabelColor"));
                emitter.Emit(new Scalar(null, node.LabelColor.A + ", " + node.LabelColor.R + ", " + node.LabelColor.G + ", " + node.LabelColor.B));
            }
            if (node.LabelFont != null)
            {
                emitter.Emit(new Scalar(null, "LabelFont"));
                emitter.Emit(new Scalar(null, node.LabelFont.ToString()));
                emitter.Emit(new Scalar(null, "LabelFontSize"));
                emitter.Emit(new Scalar(null, node.LabelFontSize.ToString()));
            }

            emitter.Emit(new MappingEnd());
        }
    }
    internal sealed class PointOfInterestRenderingTypeConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(PointOfInterestRendering);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            throw new NotImplementedException();
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

            var node = (PointOfInterestRendering)value;
            if (node.IconColor != null)
            {
                emitter.Emit(new Scalar(null, "IconColor"));
                emitter.Emit(new Scalar(null, node.IconColor.A + ", " + node.IconColor.R + ", " + node.IconColor.G + ", " + node.IconColor.B));
                emitter.Emit(new Scalar(null, "IconShape"));
                emitter.Emit(new Scalar(null, node.IconShape.ToString()));
                emitter.Emit(new Scalar(null, "IconSize"));
                emitter.Emit(new Scalar(null, node.IconSize.ToString()));
                emitter.Emit(new Scalar(null, "IconThickness"));
                emitter.Emit(new Scalar(null, node.IconThickness.ToString()));
            }
            if (node.LineColor != null)
            {
                emitter.Emit(new Scalar(null, "LineColor"));
                emitter.Emit(new Scalar(null, node.LineColor.A + ", " + node.LineColor.R + ", " + node.LineColor.G + ", " + node.LineColor.B));
                emitter.Emit(new Scalar(null, "LineThickness"));
                emitter.Emit(new Scalar(null, node.LineThickness.ToString()));
                emitter.Emit(new Scalar(null, "ArrowHeadSize"));
                emitter.Emit(new Scalar(null, node.ArrowHeadSize.ToString()));
            }
            if (node.LabelColor != null)
            {
                emitter.Emit(new Scalar(null, "LabelColor"));
                emitter.Emit(new Scalar(null, node.LabelColor.A + ", " + node.LabelColor.R + ", " + node.LabelColor.G + ", " + node.LabelColor.B));
            }
            if (node.LabelFont != null)
            {
                emitter.Emit(new Scalar(null, "LabelFont"));
                emitter.Emit(new Scalar(null, node.LabelFont.ToString()));
                emitter.Emit(new Scalar(null, "LabelFontSize"));
                emitter.Emit(new Scalar(null, node.LabelFontSize.ToString()));
            }

            emitter.Emit(new MappingEnd());
        }
    }
    internal sealed class IconRenderingTypeConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(IconRendering);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            throw new NotImplementedException();
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

            var node = (IconRendering)value;
            if (node.IconColor != null)
            {
                emitter.Emit(new Scalar(null, "IconColor"));
                emitter.Emit(new Scalar(null, node.IconColor.A + ", " + node.IconColor.R + ", " + node.IconColor.G + ", " + node.IconColor.B));
                emitter.Emit(new Scalar(null, "IconShape"));
                emitter.Emit(new Scalar(null, node.IconShape.ToString()));
                emitter.Emit(new Scalar(null, "IconSize"));
                emitter.Emit(new Scalar(null, node.IconSize.ToString()));
                emitter.Emit(new Scalar(null, "IconThickness"));
                emitter.Emit(new Scalar(null, node.IconThickness.ToString()));
            }

            emitter.Emit(new MappingEnd());
        }
    }
    internal sealed class AreaArrayYamlTypeConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(Area[]);
        }

        public object ReadYaml(IParser parser, Type type)
        {
            if (parser.TryConsume<Scalar>(out var scalar))
            {
                var item = new List<string> { scalar.Value };
                return ParseAreaStringList(item);
            }

            if (parser.TryConsume<SequenceStart>(out var _))
            {
                var items = new List<string>();
                while (parser.TryConsume<Scalar>(out var scalarItem))
                {
                    items.Add(scalarItem.Value);
                }
                parser.Consume<SequenceEnd>();
                return ParseAreaStringList(items); ;
            }
            return new Area[0];
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            var node = (Area[])value;
            emitter.Emit(new SequenceStart(null, null, false, SequenceStyle.Block));

            foreach (var child in node)
            {
                emitter.Emit(new Scalar(null, child.Name()));
            }

            emitter.Emit(new SequenceEnd());
        }

        private Area[] ParseAreaStringList(List<string> areas)
        {
            return areas
                .Select(o => LookupAreaByName(o.Trim()))
                .Where(o => o != Area.None)
                .ToArray();
        }

        private Area LookupAreaByName(string name)
        {
            return Enum.GetValues(typeof(Area)).Cast<Area>().FirstOrDefault(area => area.NameInternal().ToLower() == name.ToLower());
        }
    }

    internal sealed class ItemQualityYamlTypeConverter : IYamlTypeConverter
    {
        public bool Accepts(Type type)
        {
            return type == typeof(ItemQuality[]);
        }
        
        public object ReadYaml(IParser parser, Type type)
        {
            if (parser.TryConsume<Scalar>(out var scalar))
            {
                var items = new List<string>() {scalar.Value};
                return ParseItemQuality(items);
            }

            if (parser.TryConsume<SequenceStart>(out var _))
            {
                var items = new List<string>();
                while (parser.TryConsume<Scalar>(out var scalarItem))
                {
                    items.Add(scalarItem.Value);
                }

                parser.Consume<SequenceEnd>();
                return ParseItemQuality(items);
            }
            
            return null;
        }

        private ItemQuality[] ParseItemQuality(List<string> quality)
        {
            return quality.Select(q =>
            {
                ItemQuality parsedQuality;
                var success = Enum.TryParse(q.ToUpper(), out parsedQuality);
                return new {success, parsedQuality};
            }).Where(x => x.success).Select(x => x.parsedQuality).ToArray();
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
